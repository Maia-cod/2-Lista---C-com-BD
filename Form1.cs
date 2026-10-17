using System;
using System.Data;
using System.Windows.Forms;

namespace Aplicacao04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            try
            {
                AlunosDB alunoBD = new AlunosDB();
                dataGridView1.DataSource = alunoBD.getAlunos();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private Alunos? MontarAluno()
        {
            if (TxtMat.Text.Equals(""))
            {
                MessageBox.Show("Informe a matrícula do aluno.");
                TxtMat.Focus();
                return null;
            }
            if (TxtNome.Text.Equals(""))
            {
                MessageBox.Show("Informe o nome do aluno.");
                TxtNome.Focus();
                return null;
            }

            int matricula;
            double n1, n2, media;

            if (!int.TryParse(TxtMat.Text, out matricula))
            {
                MessageBox.Show("Matrícula deve ser um número inteiro.");
                TxtMat.Focus();
                return null;
            }
            if (!double.TryParse(txtN1.Text, out n1))
            {
                MessageBox.Show("Informe a nota N1.");
                txtN1.Focus();
                return null;
            }
            if (!double.TryParse(txtN2.Text, out n2))
            {
                MessageBox.Show("Informe a nota N2.");
                txtN2.Focus();
                return null;
            }
            if (!double.TryParse(txtMedia.Text, out media))
            {
                MessageBox.Show("Informe a média.");
                txtMedia.Focus();
                return null;
            }

            string status = media >= 6 ? "Aprovado" : "Reprovado";
            return new Alunos(matricula, TxtNome.Text, n1, n2, media, status);
        }

        private void LimparCampos()
        {
            TxtMat.Text = "";
            TxtNome.Text = "";
            txtN1.Text = "";
            txtN2.Text = "";
            txtMedia.Text = "";
            TxtMat.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alunos? alunoReg = MontarAluno();
            if (alunoReg == null)
            {
                return;
            }
            try
            {
                AlunosDB alunoBD = new AlunosDB();
                alunoBD.IncluirAluno(alunoReg);
                MessageBox.Show("Registro salvo com sucesso.");
                button2.PerformClick();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Alunos? alunoReg = MontarAluno();
            if (alunoReg == null)
            {
                return;
            }
            try
            {
                AlunosDB alunoBD = new AlunosDB();
                alunoBD.AtualizarAluno(alunoReg);
                MessageBox.Show("Registro atualizado com sucesso.");
                button2.PerformClick();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int matricula;
            if (!int.TryParse(TxtMat.Text, out matricula))
            {
                MessageBox.Show("Informe a matrícula do aluno que será removido.");
                TxtMat.Focus();
                return;
            }

            DialogResult resp = MessageBox.Show(
                "Deseja realmente remover o aluno de matrícula " + matricula + "?",
                "Confirmar remoção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resp == DialogResult.No)
            {
                return;
            }

            try
            {
                AlunosDB alunoBD = new AlunosDB();
                alunoBD.ExcluirAluno(matricula);
                MessageBox.Show("Registro removido com sucesso.");
                button2.PerformClick();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparCampos();
            AtualizarGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow linha = dataGridView1.Rows[e.RowIndex];
            TxtMat.Text = linha.Cells["matricula"].Value?.ToString() ?? "";
            TxtNome.Text = linha.Cells["nome"].Value?.ToString() ?? "";
            txtN1.Text = linha.Cells["n1"].Value?.ToString() ?? "";
            txtN2.Text = linha.Cells["n2"].Value?.ToString() ?? "";
            txtMedia.Text = linha.Cells["media"].Value?.ToString() ?? "";
        }
    }
}
