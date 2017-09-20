' Summary the Module is used as a reusable library of basic arithmetic functions
' it is operations on integers, floating point, octal, binary, and hexadecimal. 
' This Module support operation like Addition, Subtraction, Multiplication, Division, Square Root, Exponent, Conversion.

Module ArithmeticFunctions
    'These public variables used for inserting and transverse values between function and sub-procedure.
    Dim value, x1, x2 As String
    Dim value3 As Integer
    ' the Main Sub procedure for the Arithmetic functions in the application which responsible: 
    ' select the type of values will be inserted and be calling the insert values and operation function.
    Public Sub Main()
        ' variables definition:
        ' value1, value2 for inserting the values for operations
        ' conversion_type used for selecting the Conversion type which integer, double, binary, octal, and hexadecimal 
        ' valuetext it has the printing message of the number of value will be inserting.
        Dim value1, value2, Conversion_type, valuetext As String

line2:
        value1 = 0
        Console.WriteLine("what type of values you will inter: integer 1, double 2, binary 3, octal 4, and hexadecimal 5, please press inter after your chose")
line1:
        ' Insert the first value
        Dim value_type As String = Console.ReadLine()
        ' return to line 1 if you insert noting
        If value_type = Nothing Then
            Console.WriteLine("----------- No type of valuies was selected, please try agine ----------------")
            GoTo Line1
        End If

        ' Insert the second value
        valuetext = "Insert the first value"
        value1 = valueType(valuetext, value_type)
        x2 = x1
        While True
            Console.WriteLine("chose your type of operation: Addition 1,Subtraction 2, Multiplication 3,Division 4,Exponent 5, Square Root 6, Conversion 7, Delete 8, End 9  please press inter after your chose")
            Dim operation_type As Integer = Console.ReadLine()
            If operation_type < 6 Then
                valuetext = "Insert the second value"
                value2 = valueType(valuetext, value_type)
            ElseIf operation_type = 8 Then
                ' select other type of values 
                GoTo line2
            ElseIf operation_type = 9 Then
                ' exit for the program
                Exit While
            End If
            ' this select statment to select a type of operation 
            Select Case operation_type
                Case 1
                    If value_type > 3 Then
                        Console.Write("addition of tow values " & "" & value1 & "+" & value2)
                        value1 = addition(x2, x1, value_type)
                    Else
                        Console.Write("addition of tow values " & "" & x2 & "+" & x1)
                        value1 = addition(value1, value2, value_type)
                    End If
                Case 2

                    If value_type > 3 Then
                        Console.Write("subtraction of tow values " & "" & value1 & "-" & value2)
                        value1 = Subtraction(x2, x1, value_type)
                    Else
                        Console.Write("subtraction of tow values " & "" & x2 & "-" & x1)
                        value1 = Subtraction(value1, value2, value_type)
                    End If
                Case 3
                    If value_type > 3 Then
                        Console.Write("multiplication of tow values " & "" & value1 & "*" & value2)
                        value1 = Multiplication(x2, x1, value_type)
                    Else
                        Console.Write("multiplication of tow values " & "" & x2 & "*" & x1)
                        value1 = Multiplication(value1, value2, value_type)
                    End If
                Case 4
                    If value_type > 3 Then
                        Console.Write("division of tow values " & "" & value1 & "/" & value2)
                        value1 = Division(x2, x1, value_type)
                    Else
                        Console.Write("division of tow values " & "" & x2 & "/" & x1)
                        value1 = Division(value1, value2, value_type)
                    End If
                Case 5
                    If value_type > 3 Then
                        Console.Write("Exponent of tow values " & "" & value1 & "^" & value2)
                        value1 = Exponent(x2, x1, value_type)
                    Else
                        Console.Write("Exponent of tow values " & "" & x2 & "^" & x1)
                        value1 = Exponent(value1, value2, value_type)
                    End If
                Case 6
                    If value_type > 3 Then
                        Square_Root(x2, value_type)
                    Else
                        Square_Root(value1, value_type)
                    End If
                Case 7
                    Console.WriteLine("Please select which type you want this number to convert: integer 1, double 2, binary 3, octal 4, and hexadecimal 5")
                    Conversion_type = Console.ReadLine()
                    Conversion(value1, Conversion_type)

            End Select
        End While

    End Sub
    ' the valueType function first works to insert values 
    ' Second to convert values depends on the type we selected in the main()sub-procedure.
    Public Function valueType(ByVal valuetext, ByVal value_type) As String
        Dim type As String
line2:
        Select Case value_type
            Case "1"
                type = "integer"

                Console.WriteLine(valuetext)
                value = Console.ReadLine()
                x1 = value
                If value = Nothing Then
                    Console.WriteLine("----------- No value was intered, please inter the value ----------------")
                    GoTo Line2
                End If
                value = Convert.ToDecimal(value)
            Case "2"
                type = "double"
                Console.WriteLine(valuetext)
                value = Console.ReadLine()
            Case "3"
                type = "binary"
                Console.WriteLine(valuetext)
                value = Console.ReadLine()
                x1 = value
                If value = Nothing Then
                    Console.WriteLine("----------- No value was intered, please inter the value ----------------")
                    GoTo Line2
                End If
                value = Convert.ToInt32(value, 2)
            Case "4"
                type = "octal"
                Console.WriteLine(valuetext)
                value = Console.ReadLine()
                x1 = value
                If value = Nothing Then
                    Console.WriteLine("----------- No value was intered, please inter the value ----------------")
                    GoTo Line2
                End If
                value = Convert.ToString(value, 8)
            Case "5"
                type = "hexadecimal"
                Console.WriteLine(valuetext)
                value = Console.ReadLine()
                x1 = value
                If value = Nothing Then
                    Console.WriteLine("----------- No value was intered, please inter the value ----------------")
                    GoTo Line2
                End If
                'value = Convert.ToInt16(value)
                value = Hex(value)
            Case Else
                type = "no type of value was selected"
                Console.WriteLine("----------- No type of valuies was selected, please try agine ----------------")
                Main()
        End Select
        Return value
    End Function

    ' the function works to add any types of values and send them to a conversion function to convert the result and printed 
    ' then return the original result to the main() sub-procedure.
    Public Function addition(ByVal value1 As Integer, ByVal value2 As Integer, ByVal value_type As String) As String
        Dim sum As Double
        sum = value1 + value2
        Conversion(sum, value_type)
        'Console.WriteLine(sum)
        Console.WriteLine("======================================")
        Return sum
    End Function
    ' the function works to subtraction any types of values and send them to a conversion function to convert the result and printed 
    ' then return the original result to the main() sub-procedure.
    Public Function Subtraction(ByVal value1 As Double, ByVal value2 As Double, ByVal value_type As String) As String
        Dim subtr As Double
        subtr = value1 - value2
        Conversion(subtr, value_type)
        Console.WriteLine(subtr)
        Console.WriteLine("======================================")
        Return subtr
    End Function
    ' the function works to multiplication any types of values and send them to conversion function to convert the result and printed 
    ' then return the result to the main() sub-procedure.
    Public Function Multiplication(ByVal value1 As Integer, ByVal value2 As Integer, ByVal value_type As String) As String
        Dim mult As Integer
        mult = value1 * value2
        Conversion(mult, value_type)
        Console.WriteLine(mult)
        Console.WriteLine("======================================")
        Return mult
    End Function
    ' the function works to division any types of values and send them to conversion function to convert the result and printed 
    ' then return the original result to the main() sub-procedure.
    Public Function Division(ByVal value1 As Integer, ByVal value2 As Integer, ByVal value_type As String) As String
        Dim divi As Double
        divi = value1 / value2
        Conversion(divi, value_type)
        Console.WriteLine(divi)
        Console.WriteLine("======================================")
        Return divi
    End Function
    ' the function works to exponent any types of values and send them to a conversion function to convert the result and print 
    ' then return the original result to the main() sub-procedure.
    Public Function Exponent(ByVal value1 As Integer, ByVal value2 As Integer, ByVal value_type As String) As String
        Dim Exp As Double
        Exp = value1 ^ value2
        Conversion(Exp, value_type)
        Console.WriteLine(Exp)
        Console.WriteLine("======================================")
        Return Exp
    End Function
    ' the function works to square any types of value and send it to a conversion function to convert the result and print 
    ' then return the original result to the main() sub-procedure.
    Public Function Square_Root(ByVal value1 As Double, ByVal value_type As String) As String
        Dim Square As Double
        Square = value1 * value1
        Console.WriteLine("sqare root of  value is")
        Console.WriteLine(Square)
        Console.WriteLine("======================================")
        Return Square
    End Function
    ' this sub-procedure convert values between the various types (octal, hexadecimal, integer, binary), which was selected in the main() sub-procedure and printed 
    ' and did not return any values to the main() sub-procedure.
    Sub Conversion(ByVal value1 As Integer, ByVal conversion_type As String)
        Dim type As String
Line1:

        If conversion_type = Nothing Then conversion_type = 0
        Select Case conversion_type
            Case "1"
                type = "integer"
                value1 = Convert.ToString(value1)
                Console.Write("=" & value1 & " ")
                Console.WriteLine(type)
                x2 = value1
            Case "2"
                type = "double"
                value1 = Convert.ToInt32(value1)
                Console.Write("=" & value1 & " ")
                Console.WriteLine(type)
                x2 = value1
            Case "3"
                type = "binary"
                value1 = Convert.ToString(value1, 2).PadLeft(4, "0"c)
                Console.Write("=" & value1 & " ")
                Console.WriteLine(type)
                x2 = value1
            Case "4"
                type = "octal"
                Dim oct As String
                oct = Convert.ToString(value1, 8)
                Console.Write("=" & oct & " ")
                Console.WriteLine(type)
                x2 = value1
            Case "5"
                type = "hexadecimal"
                Dim hex As String
                hex = Convert.ToString(value1, 16)
                Console.Write("=" & hex & " ")
                Console.WriteLine(type)
                x2 = value1

            Case "0"
                type = "no convert type was selected"
                Console.WriteLine("----------- No convert type was selected, please try agine ----------------")
                GoTo Line1
        End Select
        Console.WriteLine("======================================")
    End Sub
End Module