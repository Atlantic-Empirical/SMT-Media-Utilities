Imports System
Imports System.Globalization
Imports Microsoft.VisualBasic

Module ToUInt64ProviderDemo

    Dim format As String = "{0,-24}{1,-22}{2}"

    ' Get the exception type name; remove the namespace prefix.
    Function GetExceptionType(ByVal ex As Exception) As String

        Dim exceptionType As String = ex.GetType().ToString()
        Return exceptionType.Substring(exceptionType.LastIndexOf("."c) + 1)
    End Function

    Sub ConvertToUInt64(ByVal numericStr As String, _
        ByVal provider As IFormatProvider)

        Dim defaultValue As Object
        Dim providerValue As Object

        ' Convert numericStr to UInt64 without a format provider.
        Try
            defaultValue = Convert.ToUInt64(numericStr)
        Catch ex As Exception
            defaultValue = GetExceptionType(ex)
        End Try

        ' Convert numericStr to UInt64 with a format provider.
        Try
            providerValue = Convert.ToUInt64(numericStr, provider)
        Catch ex As Exception
            providerValue = GetExceptionType(ex)
        End Try

        Console.WriteLine(format, numericStr, _
            defaultValue, providerValue)
    End Sub

    Sub Main()

        ' Create a NumberFormatInfo object and set several of its
        ' properties that apply to numbers.
        Dim provider As NumberFormatInfo = New NumberFormatInfo()

        ' These properties affect the conversion.
        provider.PositiveSign = "pos "
        provider.NegativeSign = "neg "

        ' These properties do not affect the conversion.
        ' The input string cannot have decimal and group separators.
        provider.NumberDecimalSeparator = "."
        provider.NumberGroupSeparator = ","
        provider.NumberGroupSizes = New Integer() {3}

        Console.WriteLine("This example of" & vbCrLf & _
            "  Convert.ToUInt64( String ) and " & vbCrLf & _
            "  Convert.ToUInt64( String, IFormatProvider ) " & _
            vbCrLf & "generates the following output. It " & _
            "converts several strings to unsigned " & vbCrLf & _
            "Long values, using default formatting " & _
            "or a NumberFormatInfo object." & vbCrLf)
        Console.WriteLine(format, "String to convert", _
            "Default/exception", "Provider/exception")
        Console.WriteLine(format, "-----------------", _
            "-----------------", "------------------")

        ' Convert strings, with and without an IFormatProvider.
        ConvertToUInt64("123456789012", provider)
        ConvertToUInt64("+123456789012", provider)
        ConvertToUInt64("pos 123456789012", provider)
        ConvertToUInt64("123456789012.", provider)
        ConvertToUInt64("123,456,789,012", provider)
        ConvertToUInt64("18446744073709551615", provider)
        ConvertToUInt64("18446744073709551616", provider)
        ConvertToUInt64("-1", provider)
    End Sub

End Module
