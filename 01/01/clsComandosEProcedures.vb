Imports System.Data.SqlClient

Public Class clsComandosEProcedures
End Class

Namespace Classes

    Public Class NomeTime
        Private _nometime1 As String
        Private _nometime2 As String

        Public Property NomeTime1() As String
            Get
                Return _nometime1
            End Get
            Set(ByVal value As String)
                _nometime1 = value
            End Set
        End Property

        Public Property NomeTime2() As String
            Get
                Return _nometime2
            End Get
            Set(ByVal value As String)
                _nometime2 = value
            End Set
        End Property

    End Class

    Public Class Tecnico
        Private _nome As String
        Private _dataNascimento As Date
        Private _apelido As String
        Private _codPais As Integer

        Public Property Nome() As String
            Get
                Return _nome
            End Get
            Set(ByVal value As String)
                _nome = value
            End Set
        End Property

        Public Property DataNascimento() As Date
            Get
                Return _dataNascimento
            End Get
            Set(ByVal value As Date)
                _dataNascimento = value
            End Set
        End Property

        Public Property Apelido() As String
            Get
                Return _apelido
            End Get
            Set(ByVal value As String)
                _apelido = value
            End Set
        End Property

        Public Property codPais() As Integer
            Get
                Return _codPais
            End Get
            Set(ByVal value As Integer)
                _codPais = value
            End Set
        End Property
    End Class

    Public Class Jogador

        Private _Nome As String
        Public Property Nome() As String
            Get
                Return _Nome
            End Get
            Set(ByVal value As String)
                _Nome = value
            End Set
        End Property


        Private _Apelido As String
        Public Property Apelido() As String
            Get
                Return _Apelido
            End Get
            Set(ByVal value As String)
                _Apelido = value
            End Set
        End Property


        Private _Nacionalidade As Integer
        Public Property Nacionalidade() As Integer
            Get
                Return _Nacionalidade
            End Get
            Set(ByVal value As Integer)
                _Nacionalidade = value
            End Set
        End Property


        Private _DataNascimento As Date
        Public Property DataNascimento() As Date
            Get
                Return _DataNascimento
            End Get
            Set(ByVal value As Date)
                _DataNascimento = value
            End Set
        End Property


        Private _Altura As Integer
        Public Property Altura() As Integer
            Get
                Return _Altura
            End Get
            Set(ByVal value As Integer)
                _Altura = value
            End Set
        End Property


        Private _Peso As Integer
        Public Property Peso() As Integer
            Get
                Return _Peso
            End Get
            Set(ByVal value As Integer)
                _Peso = value
            End Set
        End Property


        Private _Pe As String
        Public Property Pe() As String
            Get
                Return _Pe
            End Get
            Set(ByVal value As String)
                _Pe = value
            End Set
        End Property


        Private _Posicao As Integer
        Public Property Posicao() As Integer
            Get
                Return _Posicao
            End Get
            Set(ByVal value As Integer)
                _Posicao = value
            End Set
        End Property


        Private _Clube As Integer
        Public Property Clube() As Integer
            Get
                Return _Clube
            End Get
            Set(ByVal value As Integer)
                _Clube = value
            End Set
        End Property


        Private _Imagem As String
        Public Property Imagem() As String
            Get
                Return _Imagem
            End Get
            Set(ByVal value As String)
                _Imagem = value
            End Set
        End Property

    End Class
End Namespace

Public Class comandos





End Class