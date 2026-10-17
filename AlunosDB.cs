using System;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace Aplicacao04
{
    public class AlunosDB
    {
        string conexao;

        public AlunosDB()
        {
            this.conexao = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        }

        public void IncluirAluno(Alunos alunos)
        {
            MySqlConnection CN = new MySqlConnection(conexao);
            MySqlCommand Com = CN.CreateCommand();
            Com.CommandText = "INSERT INTO Alunos(matricula,nome,n1,n2,media,status) " +
                              "Values(?matricula,?nome,?n1,?n2,?media,?status)";
            Com.Parameters.AddWithValue("?matricula", alunos.getMatricula());
            Com.Parameters.AddWithValue("?nome", alunos.getNome());
            Com.Parameters.AddWithValue("?n1", alunos.getN1());
            Com.Parameters.AddWithValue("?n2", alunos.getN2());
            Com.Parameters.AddWithValue("?media", alunos.getMedia());
            Com.Parameters.AddWithValue("?status", alunos.getStatus());
            try
            {
                CN.Open();
                int registrosAfetados = Com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }

        public DataTable getAlunos()
        {
            MySqlConnection CN = new MySqlConnection(conexao);
            MySqlCommand cmd = CN.CreateCommand();
            MySqlDataAdapter da;
            cmd.CommandText = "SELECT * from Alunos";
            try
            {
                CN.Open();
                cmd = new MySqlCommand(cmd.CommandText, CN);
                da = new MySqlDataAdapter(cmd);
                DataTable dtAlunos = new DataTable();
                da.Fill(dtAlunos);
                return dtAlunos;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }

        public void ExcluirAluno(int matricula)
        {
            MySqlConnection CN = new MySqlConnection(conexao);
            MySqlCommand Com = CN.CreateCommand();
            Com.CommandText = "DELETE FROM Alunos WHERE matricula = ?matricula";
            Com.Parameters.AddWithValue("?matricula", matricula);
            try
            {
                CN.Open();
                int registrosAfetados = Com.ExecuteNonQuery();
                if (registrosAfetados == 0)
                {
                    throw new ApplicationException("Nenhum aluno encontrado com a matrícula informada.");
                }
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }

        public void AtualizarAluno(Alunos alunos)
        {
            MySqlConnection CN = new MySqlConnection(conexao);
            MySqlCommand Com = CN.CreateCommand();
            Com.CommandText = "UPDATE Alunos SET nome = ?nome, n1 = ?n1, n2 = ?n2, " +
                              "media = ?media, status = ?status WHERE matricula = ?matricula";
            Com.Parameters.AddWithValue("?matricula", alunos.getMatricula());
            Com.Parameters.AddWithValue("?nome", alunos.getNome());
            Com.Parameters.AddWithValue("?n1", alunos.getN1());
            Com.Parameters.AddWithValue("?n2", alunos.getN2());
            Com.Parameters.AddWithValue("?media", alunos.getMedia());
            Com.Parameters.AddWithValue("?status", alunos.getStatus());
            try
            {
                CN.Open();
                int registrosAfetados = Com.ExecuteNonQuery();
                if (registrosAfetados == 0)
                {
                    throw new ApplicationException("Nenhum aluno encontrado com a matrícula informada.");
                }
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }

        public DataTable getAlunoPorMatricula(int matricula)
        {
            MySqlConnection CN = new MySqlConnection(conexao);
            MySqlCommand cmd = CN.CreateCommand();
            cmd.CommandText = "SELECT * FROM Alunos WHERE matricula = ?matricula";
            cmd.Parameters.AddWithValue("?matricula", matricula);
            try
            {
                CN.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dtAlunos = new DataTable();
                da.Fill(dtAlunos);
                return dtAlunos;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }
    }
}
