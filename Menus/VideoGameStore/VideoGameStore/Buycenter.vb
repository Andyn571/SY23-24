Imports System.Reflection.Emit
Module Buycenter
    Public Event coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer)
    Public Event buyevent(p As Image)
    Public Property quarters As Integer
    Public Property nickels As Integer
    Public Property dollars As Integer
    Public Property dimes As Integer
    Dim _total As Decimal
    Public ReadOnly Property total As Decimal
        Get
            _total = dollars + quarters * 0.25 + dimes * 0.1 + nickels * 0.05
            Return _total
        End Get
    End Property
    Sub coinreturn()
        RaiseEvent coinreturnevent(dollars, quarters, dimes, nickels)
        quarters = 0
        dollars = 0
        nickels = 0
        dimes = 0
    End Sub
    Sub insertquarter()
        quarters = quarters + 1
    End Sub
    Public Sub insertnickle()
        nickels = nickels + 1
    End Sub
    Sub insertdollar()
        dollars = dollars + 1
    End Sub
    Sub insertdime()
        dimes = dimes + 1
    End Sub
End Module
