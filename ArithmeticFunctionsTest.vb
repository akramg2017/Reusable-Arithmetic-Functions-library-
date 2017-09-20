Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Arithmetic



'''<summary>
'''This is a test class for ArithmeticFunctionsTest and is intended
'''to contain all ArithmeticFunctionsTest Unit Tests
'''</summary>
<TestClass()> _
Public Class ArithmeticFunctionsTest


    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Additional test attributes"
    '
    'You can use the following additional attributes as you write your tests:
    '
    'Use ClassInitialize to run code before running the first test in the class
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Use ClassCleanup to run code after all tests in a class have run
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Use TestInitialize to run code before running each test
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Use TestCleanup to run code after each test has run
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


    '''<summary>
    '''A test for valueType
    '''</summary>
    <TestMethod()> _
    Public Sub valueTypeTest()
        Dim valuetext As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim value_type As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = ArithmeticFunctions.valueType(valuetext, value_type)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for subtraction
    '''</summary>
    <TestMethod()> _
    Public Sub subtractionTest()
        Dim value1 As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim value2 As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim value_type As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = ArithmeticFunctions.subtraction(value1, value2, value_type)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Square_Root
    '''</summary>
    <TestMethod()> _
    Public Sub Square_RootTest()
        Dim value1 As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim value_type As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = ArithmeticFunctions.Square_Root(value1, value_type)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Multiplication
    '''</summary>
    <TestMethod()> _
    Public Sub MultiplicationTest()
        Dim value1 As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim value2 As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim value_type As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = ArithmeticFunctions.Multiplication(value1, value2, value_type)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Main
    '''</summary>
    <TestMethod()> _
    Public Sub MainTest()
        ArithmeticFunctions.Main()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Exponent
    '''</summary>
    <TestMethod()> _
    Public Sub ExponentTest()
        Dim value1 As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim value2 As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim value_type As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = ArithmeticFunctions.Exponent(value1, value2, value_type)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Division
    '''</summary>
    <TestMethod()> _
    Public Sub DivisionTest()
        Dim value1 As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim value2 As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim value_type As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = ArithmeticFunctions.Division(value1, value2, value_type)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Conversion
    '''</summary>
    <TestMethod()> _
    Public Sub ConversionTest()
        Dim value1 As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim conversion_type As String = String.Empty ' TODO: Initialize to an appropriate value
        ArithmeticFunctions.Conversion(value1, conversion_type)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for addition
    '''</summary>
    <TestMethod()> _
    Public Sub additionTest()
        Dim value1 As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim value2 As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim value_type As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = ArithmeticFunctions.addition(value1, value2, value_type)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub
End Class
