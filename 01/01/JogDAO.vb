Imports _01.Classes
Imports System.Data.SqlClient

Public Class SistemaDAO

    Public Function InserirJogador(ByVal jogador As Jogador)
        Using cn As SqlConnection = conexao()
            Dim sql As String = "insertJogador"
            Dim cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandText = sql
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("nome", jogador.Nome)
                .AddWithValue("apelido", jogador.Apelido)
                .AddWithValue("dataNascimento", jogador.DataNascimento)
                .AddWithValue("pePredom", jogador.Pe)
                .AddWithValue("altura", jogador.Altura)
                .AddWithValue("peso", jogador.Peso)
                .AddWithValue("imagem", jogador.Imagem)
                .AddWithValue("codClube", jogador.Clube)
                .AddWithValue("codPais", jogador.Nacionalidade)
                .AddWithValue("codPosicao", jogador.Posicao)
            End With
            cn.Open()
            cmd.ExecuteReader()
            cn.Close()
            Return True
        End Using
    End Function

    Public Function InserirTecnico(ByVal tecnico As Tecnico)
        Using cn As SqlConnection = conexao()
            Dim sql As String = "insertTecnico"
            Dim cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandText = sql
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("nome", tecnico.Nome)
                .AddWithValue("dtNasc", tecnico.DataNascimento)
                .AddWithValue("apelido", tecnico.Apelido)
                .AddWithValue("codPais", tecnico.codPais)
            End With
            cn.Open()
            cmd.ExecuteReader()
            cn.Close()
            Return True
        End Using
    End Function


End Class
