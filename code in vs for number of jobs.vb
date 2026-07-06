Option Strict On
Imports System

Module Program
    Const MaxJobs As Integer = 100

    Dim Jobs(MaxJobs - 1, 1) As Integer
    Dim NumberOfJobs As Integer

    Sub Main()
        Initialise()

        AddJob(12, 10)
        AddJob(526, 9)
        AddJob(33, 8)
        AddJob(12, 9)
        AddJob(78, 1)

        InsertionSort()
        PrintArray()
    End Sub

    Sub Initialise()
        For X = 0 To MaxJobs - 1
            For Y = 0 To 1
                Jobs(X, Y) = -1
            Next
        Next

        NumberOfJobs = 0
    End Sub

    Sub AddJob(JobNumber As Integer, Priority As Integer)
        If NumberOfJobs = MaxJobs Then
            Console.WriteLine("Not added")
        Else
            Jobs(NumberOfJobs, 0) = JobNumber
            Jobs(NumberOfJobs, 1) = Priority
            NumberOfJobs = NumberOfJobs + 1
            Console.WriteLine("Added")
        End If
    End Sub

    Sub InsertionSort()
        For Index = 1 To NumberOfJobs - 1
            Dim CurrentJobNumber As Integer = Jobs(Index, 0)
            Dim CurrentPriority As Integer = Jobs(Index, 1)
            Dim Position As Integer = Index
            Dim Placed As Boolean = False

            While Position > 0 And Not Placed
                If Jobs(Position - 1, 1) > CurrentPriority Then
                    Jobs(Position, 0) = Jobs(Position - 1, 0)
                    Jobs(Position, 1) = Jobs(Position - 1, 1)
                    Position = Position - 1
                Else
                    Placed = True
                End If
            End While

            Jobs(Position, 0) = CurrentJobNumber
            Jobs(Position, 1) = CurrentPriority
        Next
    End Sub

    Sub PrintArray()
        For X = 0 To NumberOfJobs - 1
            Console.WriteLine(Jobs(X, 0) & " priority " & Jobs(X, 1))
        Next
    End Sub
End Module
