'Written by bedezub

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
        If chkOilChange.Checked AndAlso chkLubeJob.Checked Then
            price = oil_change_service + lube_job_service
        ElseIf chkOilChange.Checked Then
            price = oil_change_service
        ElseIf chkLubeJob.Checked Then
            price = lube_job_service
        Else
            price = 0
        End If
        Return price
    End Function

    Function FlushCharges()
        Dim price As Double
        If chkRadiator.Checked AndAlso chkTransmission.Checked Then
            price = radiator_flush_service + transmission_flush_service
        ElseIf chkRadiator.Checked Then
            price = radiator_flush_service
        ElseIf chkTransmission.Checked Then
            price = transmission_flush_service
        Else
            price = 0
        End If
        Return price
    End Function

    Function MiscCharges()
        Dim price As Double
        If chkInspection.Checked AndAlso chkMuffler.Checked AndAlso chkTireRotation.Checked Then
            price = inspection_service + muffler_replacement_service + tire_rotation_service
            Console.WriteLine("masuk 1")
        Else
            If chkInspection.Checked AndAlso chkMuffler.Checked AndAlso Not chkTireRotation.Checked Then
                price = inspection_service + muffler_replacement_service
                Console.WriteLine("masuk 2")
                Console.WriteLine(chkMuffler.Checked)
            ElseIf chkInspection.Checked And chkTireRotation.Checked AndAlso Not chkMuffler.Checked Then
                price = inspection_service + tire_rotation_service
                Console.WriteLine(chkTireRotation.Checked)
                Console.WriteLine("masuk 3")
            ElseIf chkMuffler.Checked AndAlso chkTireRotation.Checked AndAlso Not chkInspection.Checked Then
                price = muffler_replacement_service + tire_rotation_service
                Console.WriteLine("masuk 4")
            Else
                If chkInspection.Checked Then
                    price = inspection_service
                    Console.WriteLine("masuk 5")
                ElseIf chkMuffler.Checked Then
                    price = muffler_replacement_service
                    Console.WriteLine("masuk 6")
                ElseIf chkTireRotation.Checked Then
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
        If txtLabor.Text = Nothing AndAlso txtPart.Text = Nothing Then
        Else
            If txtLabor.Text = Nothing Then
                price = Double.Parse(txtPart.Text)
            ElseIf txtPart.Text = Nothing Then
                price = Double.Parse(txtLabor.Text)
            ElseIf Double.Parse(txtLabor.Text) > 0 AndAlso Double.Parse(txtPart.Text) > 0 Then
                price = (Double.Parse(txtLabor.Text) * 70) + Double.Parse(txtPart.Text)
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
        If txtPart.Text = Nothing Then
        Else
            price += (Double.Parse(txtPartPrice.Text) * 0.06)
        End If
        Return price
    End Function

    Function TotalCharges()
        total_price = OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges() + TaxCharges()
        Return total_price
    End Function

    Function ClearOilLube()
        DirectCast(chkOilChange, CheckBox).Checked = False
        DirectCast(chkLubeJob, CheckBox).Checked = False
    End Function

    Function ClearFlushes()
        DirectCast(chkRadiator, CheckBox).Checked = False
        DirectCast(chkTransmission, CheckBox).Checked = False
    End Function

    Function ClearMisc()
        DirectCast(chkInspection, CheckBox).Checked = False
        DirectCast(chkMuffler, CheckBox).Checked = False
        DirectCast(chkTireRotation, CheckBox).Checked = False
    End Function

    Function ClearOther()
        txtPart.Clear()
        txtLabor.Clear()
        txtPartPrice.Clear()
        txtTaxPrice.Clear()
        txtServicePrice.Clear()
    End Function

    Function ClearFees()
        txtTotalPrice.Clear()
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcTotal.Click
        txtPartPrice.Text = txtPart.Text
        txtServicePrice.Text = txtLabor.Text
        txtTaxPrice.Text = TaxCharges()
        txtTotalPrice.Text = TotalCharges()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
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
        txtPartPrice.BackColor() = Color.Red
        txtServicePrice.BackColor() = Color.Red
        txtTotalPrice.BackColor() = Color.Red
        txtTaxPrice.BackColor() = Color.Red
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        txtPartPrice.BackColor() = Color.Blue
        txtServicePrice.BackColor() = Color.Blue
        txtTotalPrice.BackColor() = Color.Blue
        txtTaxPrice.BackColor() = Color.Blue
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        txtPartPrice.BackColor() = Color.White
        txtServicePrice.BackColor() = Color.White
        txtTotalPrice.BackColor() = Color.White
        txtTaxPrice.BackColor() = Color.White
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
