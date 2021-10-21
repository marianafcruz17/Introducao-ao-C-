using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windown.Forms;

namespace SimplePaint{
    public partial class FormPrincipal : Form{

        private bool flagPintar = false;
        private Graphics graphicsPainelPintura;
        private float espessuraCaneta;
        private Color corBorracha;
        private bool flagApagar = false;
        private Image imagemASalvar;
        private Graphics graphicsImagemASalvar;

        public FormPrincipal(){
            InitializeComponet();

            buttonBorracha.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            buttonLimpar.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            buttonSalvar.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;

            for(int i=2;i<=100;i+=2){
                comboBoxEspessuraDaCaneta.Items.Add(i);
            }

            comboBoxEspessuraDaCaneta.Text = "10";
            comboBoxEspessuraDaCaneta.IntegralHeight = false;
            comboBoxEspessuraDaCaneta.MaxDropDownItems = 5;

            graphicsPainelPintura = panelPintura.CreateGraphics();
            espessuraCaneta = float.Parse(comboBoxEspessuraDaCaneta.Text);
            corBorracha = panelPintura.BackColor;

            imagemASalvar = new Bitmap(panelPintura.Width,panelPintura.Height);
            graphicsImagemASalvar = Graphics.FromImage(imagemASalvar);
            graphicsImagemASalvar.Clear(panelPintura.BackColor);
        }

        private void buttonCorCaneta_Click(object sender,EventArgs e){
            var colorDialog = new ColorDialog();
            
            //exibe na forma modal
           var corEscolhida = colorDialog.showDialog();

           if(corEscolhida==DialogResult.OK){
               buttonCorCaneta.BackColor = colorDialog.Color;
           }
        }

        private void panelPintura_MouseDown(object sender,MouseEventArgs e){
            flagPintar = true;
        }

        private void panelPintura_MouseUp(object sender,MouseEventArgs e){
            flagPintar = false;
        }

        private void panelPintura_MouseMove(object sender,MouseEventArgs e){
            if(flagPintar){
                if(!flagApagar){
                    graphicsPainelPintura.DrawEllipse(new Pen(buttonCorCaneta.BackColor,espessuraCaneta),new RectangleF(e.X,e.Y,espessuraCaneta,espessuraCaneta));
                    graphicsImagemASalvar.DrawEllipse(new Pen(buttonCorCaneta.BackColor,espessuraCaneta),new RectangleF(e.X,e.Y,espessuraCaneta,espessuraCaneta));
                }else{
                    graphicsPainelPintura.DrawRetangle(new Pen(corBorracha,espessuraCaneta),new Rectangle(e.X,e.Y,(int)espessuraCaneta,(int)espessuraCaneta));
                    graphicsImagemASalvar.DrawRetangle(new Pen(corBorracha,espessuraCaneta),new Rectangle(e.X,e.Y,(int)espessuraCaneta,(int)espessuraCaneta));
                }
                
            }
        }

        private void buttonLimpar_Click(object sender,EventArgs e){
            if(MessageBox.Show("Tem certeza disso? Todo o desenho será apagado!", "Apagar desenho", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK){
                graphicsPainelPintura.Clear(Color.White);
                imagemASalvar = new Bitmap(panelPintura.Width,panelPintura.Height);
                graphicsImagemASalvar = Graphics.FromImage(imagemASalvar);
                graphicsImagemASalvar.Clear(panelPintura.BackColor);
            }
        }

        //ocorre quando altera o item da comboBox
        private void comboBoxEspessuraDaCaneta_SelectedIndexChanged(object sender,EventArgs e){
            espessuraCaneta = float.Parse(comboBoxEspessuraDaCaneta.SelectedItem.ToString());
        }

        private void buttonBorracha_MouseDown(object sender,MouseEventArgs e){
            if(e.Button==MouseButtons.Right){
                var colorDialog = new ColorDialog();

                if(colorDialog.ShowDialog()==DialogResult.OK){
                    corBorracha = colorDialog.Color;
                }
            }else{
                if(!flagApagar){ 
                    flagApagar = true;
                    buttonBorracha.BackColor = corBorracha;
                }else{    
                    flagApagar = false;
                    buttonBorracha.BackColor = Color.BackColor;
                }

            }
        }

        private void buttonSalver_Click(object sender,EventArgs e){
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Portable Network Graphics|.png|Arquivo JPEG|.jpeg";

            if(saveFileDialog.ShowDialog()==DialogResult.OK){
                switch(saveFileDialog.FilterIndex){
                    case 1:
                        imagemASalvar.Save(saveFileDialog.FileName,ImageFormat.Png);
                        break;
                    case 2:
                        imagemASalvar.Save(saveFileDialog.FileName,ImageFormat.Jpeg);
                        break;
                }
            }
        }

        private void panelPintura_Resize(object sender,EventArgs e){
            graphicsPainelPintura = panelPintura.CreateGraphics();

            var imgTemp = new Bitmap(panelPintura.Width,panelPintura.Height);
            var graphicsImgTemp = Graphics.FromImage(imgTemp);
            graphicsImgTemp.DrawImage(imagemASalvar,0,0);
            
            imagemASalvar = imgTemp;
            graphicsImagemASalvar = graphicsImgTemp;
        }
    }
}