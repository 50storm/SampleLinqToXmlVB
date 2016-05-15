Imports System.Linq
Imports System.Xml.Linq
'https://msdn.microsoft.com/ja-jp/library/bb298736%28v=vs.110%29.aspx?cs-save-lang=1&cs-lang=csharp#code-snippet-2
Module Module1

    Sub Main()

        Dim arr As New List(Of String)
        Dim arr2 As New List(Of String)
        Dim arr3 As New List(Of String)

        Dim Persons As XElement = XElement.Load("c:\users\hiro\documents\visual studio 2015\Projects\SampleLinqXml\SampleLinqXml\XMLFile1.xml")


        Dim q = From x In Persons.<Person> Where (x.<Name>.Value Like "Hiroshi")
        For Each xxx In q
            arr.Add(xxx.<Name>.Value)
        Next



        Dim Settings As XElement = XElement.Load("c:\users\hiro\documents\visual studio 2015\Projects\SampleLinqXml\Settings.xml")
        Dim qASR5500 = From x In Settings.<Asr5500>

        arr2.Add(qASR5500.<col1>.Value)
        arr2.Add(qASR5500.<col2>.Value)
        arr2.Add(qASR5500.<col3>.Value)

        Dim qASR900 = From x In Settings.<ASR900>
        arr3.Add(qASR900.<col1>.Value)
        arr3.Add(qASR900.<col2>.Value)
        arr3.Add(qASR900.<col3>.Value)


        Dim a As Integer
        a = 1





    End Sub

End Module
