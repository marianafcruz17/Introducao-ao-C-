using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windown.Forms;
using Microsoft.VisualBasic;

namespace SimpleToPark{
    public partial class FormPrincipal : Form{
        //armazenar dados em linhas e colunas
        private DataTable bancoDeDados;
        private GerenciadorArrecadacao gerenciador;

        public FormPrincipal(){
            InitializeComponet();

            //criando tabela estacionamento
            bancoDeDados = new DataTable("Estacionamento");
            bancoDeDados.Columns.Add("Placa",typeof(string));
            bancoDeDados.Columns.Add("Entrada",typeof(string));

            dataGridViewCarrosEstacionados.DataSource = bancoDeDados;

            gerenciador = new GerenciadorArrecadacao{
                ValorHora = 10,
                Arrecadado = 0
            };

            labelValorHora.Text = $"Valor da hora: R${gerneciador.ValorHora.ToString("0.00")}";
        }

        private void buttonCadastrar_Click(object sender,EventArgs e){
            var placa = Interaction.InputBox("Digite a placa do veículo", "Entrada de veículo");

            if(!string.IsNullOrEmpty(placa)){
                bancoDeDados.Rows.Add(new string[]{placa,DateTime.Now.ToString()});
            }
        }

        private void buttonConfigurar_Click(object sender,EventArgs e){
            var valorDaHora = Interaction.InputBox("Digite o valor da hora:","Valor da hora");

            if(!string.IsNullOrEmpty(valorDaHora)){
                gerenciador.ValorHora = float.Parse(valorDaHora);
                labelValorHora.Text = $"Valor da hora: R${gerenciador.ValorHora.ToStrign("0.00")}";
            }
        }

        private void dataGridViewCarrosEstacionados_CellDoubleClick(object sender,DataGridViewCellEventArgs e){
            var entrada = DateTime.Parse(bancoDeDados.Rows[e.RowIndex].ItemArray[1].ToString());
            var placa = bancoDeDados.Rows[e.RowIndex].ItemArray[0].ToString();

            var arrecadao = gerenciador.CalcularEstadiaCliente(entrada);

            if(MessageBox.Show(this, $"Deseja encerrar o ticket de {placa}? \nValor: R${arrecadado.ToString("0.00")}","Encerrar Ticket"){
                bancoDeDados.Rows.RemoveAr(e.RowIndex);
                gerenciador.Arrecadado = arrecadado;
                labelValorArrecado.Text = $"Total arrecadado: R${gerenciador.Arrecadado.ToString("0.00")}";
            }
        }
    }

    class GerenciadorArrecadacao{
        public float ValorHora{get;set}
        private float _arrecadado;

        public float Arrecadado{
            get => _arrecadado;
            set => _arrecadado += value;
        }

        public float CalcularEstadiaCliente(DateTime entrada){
            var permanencia = DateTime.Now - entrada;

            if(permanencia.Hours <= 0)
                return ValorHora;
            else   
                return ValorHora * permanencia.Hours;
        }
    }
}