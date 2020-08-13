Public Class Main
  Shared Sub Main
    For i As Integer = 1 To 20
      If i mod 15 = 0 Then
        Console.WriteLine("FizzBuzz")
      ElseIf i mod 3 = 0 Then
        Console.WriteLine("Fizz")
      Else If i mod 5 = 0 Then
        Console.WriteLine("Buzz")
      Else
        Console.WriteLine(i)
      End If
    Next
  End Sub
End Class
