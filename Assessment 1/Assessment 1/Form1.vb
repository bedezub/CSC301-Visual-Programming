Imports System.IO

Public Class Form1

    Dim oil_change_service As Double = 91
    Dim lube_job_service As Double = 63
    Dim radiator_flush_service As Double = 105
    Dim transmission_flush_service As Double = 280
    Dim inspection_service As Double = 52
    Dim muffler_replacement_service As Double = 350
    Dim tire_rotation_service As Double = 70
    Dim total_price As Double = 0

    Function OilLubeCharges()
        Dim price As Double
        If oil_change.Checked AndAlso lube_job.Checked Then
            price = oil_change_service + lube_job_service
        ElseIf oil_change.Checked Then
            price = oil_change_service
        ElseIf lube_job.Checked Then
            price = lube_job_service
        Else
            price = 0
        End If
        Return price
    End Function

    Function FlushCharges()
        Dim price As Double
        If radiator.Checked AndAlso transmission.Checked Then
            price = radiator_flush_service + transmission_flush_service
        ElseIf radiator.Checked Then
            price = radiator_flush_service
        ElseIf transmission.Checked Then
            price = transmission_flush_service
        Else
            price = 0
        End If
        Return price
    End Function

    Function MiscCharges()
        Dim price As Double
        If inspection.Checked AndAlso muffler.Checked AndAlso tire_rotation.Checked Then
            price = inspection_service + muffler_replacement_service + tire_rotation_service
            Console.WriteLine("masuk 1")
        Else
            If inspection.Checked AndAlso muffler.Checked AndAlso Not tire_rotation.Checked Then
                price = inspection_service + muffler_replacement_service
                Console.WriteLine("masuk 2")
                Console.WriteLine(muffler.Checked)
            ElseIf inspection.Checked And tire_rotation.Checked AndAlso Not muffler.Checked Then
                price = inspection_service + tire_rotation_service
                Console.WriteLine(tire_rotation.Checked)
                Console.WriteLine("masuk 3")
            ElseIf muffler.Checked AndAlso tire_rotation.Checked AndAlso Not inspection.Checked Then
                price = muffler_replacement_service + tire_rotation_service
                Console.WriteLine("masuk 4")
            Else
                If inspection.Checked Then
                    price = inspection_service
                    Console.WriteLine("masuk 5")
                ElseIf muffler.Checked Then
                    price = muffler_replacement_service
                    Console.WriteLine("masuk 6")
                ElseIf tire_rotation.Checked Then
                    price = tire_rotation_service
                    Console.WriteLine("masuk 7")
                Else
                    price = 0

                End If
            End If
        End If
        Return price
    End Function
    Function OtherCharges()
        Dim price As Double
        If labor.Text = Nothing AndAlso part.Text = Nothing Then
        Else
            If labor.Text = Nothing Then
                price = Double.Parse(part.Text)
            ElseIf part.Text = Nothing Then
                price = Double.Parse(labor.Text)
            ElseIf Double.Parse(labor.Text) > 0 AndAlso Double.Parse(part.Text) > 0 Then
                price = (Double.Parse(labor.Text) * 70) + Double.Parse(part.Text)
            Else
                price = 0
                MessageBox.Show("Invalid input", "Please enter correct value for parts and labor",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return price
    End Function

    Function TaxCharges()
        Dim price As Double
        If part.Text = Nothing Then
        Else
            price += (Double.Parse(part_price.Text) * 0.06)
        End If
        Return price
    End Function

    Function TotalCharges()
        total_price = OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges() + TaxCharges()
        Return total_price
    End Function

    Function ClearOilLube()
        DirectCast(oil_change, CheckBox).Checked = False
        DirectCast(lube_job, CheckBox).Checked = False
    End Function

    Function ClearFlushes()
        DirectCast(radiator, CheckBox).Checked = False
        DirectCast(transmission, CheckBox).Checked = False
    End Function

    Function ClearMisc()
        DirectCast(inspection, CheckBox).Checked = False
        DirectCast(muffler, CheckBox).Checked = False
        DirectCast(tire_rotation, CheckBox).Checked = False
    End Function

    Function ClearOther()
        part.Clear()
        labor.Clear()
        part_price.Clear()
        tax_price.Clear()
    End Function

    Function ClearFees()
        total_fees.Clear()
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        part_price.Text = part.Text
        service_price.Text = labor.Text
        tax_price.Text = TaxCharges()
        total_fees.Text = TotalCharges()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearOilLube()
        ClearFlushes()
        ClearMisc()
        ClearOther()
        ClearFees()
    End Sub

    Function debug()
        Console.WriteLine(OilLubeCharges())
        Console.WriteLine(FlushCharges())
        Console.WriteLine(MiscCharges())
        Console.WriteLine(OtherCharges())
        Console.WriteLine(TaxCharges())
    End Function

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        part_price.BackColor() = Color.Red
        service_price.BackColor() = Color.Red
        total_fees.BackColor() = Color.Red
        tax_price.BackColor() = Color.Red
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        part_price.BackColor() = Color.Blue
        service_price.BackColor() = Color.Blue
        total_fees.BackColor() = Color.Blue
        tax_price.BackColor() = Color.Blue
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        part_price.BackColor() = Color.White
        service_price.BackColor() = Color.White
        total_fees.BackColor() = Color.White
        tax_price.BackColor() = Color.White
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
