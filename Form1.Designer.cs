namespace Aplicacao04
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblMat = new System.Windows.Forms.Label();
            this.TxtMat = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.lblN1 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.lblN2 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            //
            // lblMat
            //
            this.lblMat.AutoSize = true;
            this.lblMat.Location = new System.Drawing.Point(15, 18);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(50, 15);
            this.lblMat.Text = "Matrícula:";
            //
            // TxtMat
            //
            this.TxtMat.Location = new System.Drawing.Point(80, 15);
            this.TxtMat.Name = "TxtMat";
            this.TxtMat.Size = new System.Drawing.Size(80, 23);
            //
            // lblNome
            //
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 48);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.Text = "Nome:";
            //
            // TxtNome
            //
            this.TxtNome.Location = new System.Drawing.Point(80, 45);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(330, 23);
            //
            // lblN1
            //
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(15, 78);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(27, 15);
            this.lblN1.Text = "N1:";
            //
            // txtN1
            //
            this.txtN1.Location = new System.Drawing.Point(45, 75);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(60, 23);
            //
            // lblN2
            //
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(130, 78);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(27, 15);
            this.lblN2.Text = "N2:";
            //
            // txtN2
            //
            this.txtN2.Location = new System.Drawing.Point(160, 75);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(60, 23);
            //
            // lblMedia
            //
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(245, 78);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(42, 15);
            this.lblMedia.Text = "Média:";
            //
            // txtMedia
            //
            this.txtMedia.Location = new System.Drawing.Point(290, 75);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(60, 23);
            //
            // button1
            //
            this.button1.Location = new System.Drawing.Point(15, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // button5
            //
            this.button5.Location = new System.Drawing.Point(115, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 30);
            this.button5.Text = "Atualizar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            //
            // button4
            //
            this.button4.Location = new System.Drawing.Point(215, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 30);
            this.button4.Text = "Remover";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            //
            // button2
            //
            this.button2.Location = new System.Drawing.Point(315, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 30);
            this.button2.Text = "Limpar / Listar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            //
            // button3
            //
            this.button3.Location = new System.Drawing.Point(465, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 30);
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //
            // dataGridView1
            //
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 160);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(540, 250);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 426);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.TxtMat);
            this.Controls.Add(this.lblMat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Alunos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.TextBox TxtMat;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
