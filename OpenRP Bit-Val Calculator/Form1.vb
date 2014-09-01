Public Class Form1

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim endvalue, endvalue1, endvalue2, endvalue3, totalvalue As Long
        Dim kick, ban, tele, search, sleep, silence, check, grant As Long '8
        Dim map, skill, build, anounce, warn, allchat, invisible, cheats As Long
        Dim whois, merc, shake, effect, forceteam, weather, status, rename As Long
        Dim faction, credits, item, audio, bounty, toblack, training, gunitem As Long
        'Kick 
        If CheckBox1.Checked Then
            kick = 1
        Else
            kick = 0
        End If
        'Ban
        Select Case CheckBox2.CheckState
            Case CheckState.Checked
                ban = 2
            Case CheckState.Unchecked
                ban = 0
        End Select
        'Teleport
        Select Case CheckBox3.CheckState
            Case CheckState.Checked
                tele = 4
            Case CheckState.Unchecked
                tele = 0
        End Select
        'Search
        Select Case CheckBox4.CheckState
            Case CheckState.Checked
                search = 8
            Case CheckState.Unchecked
                search = 0
        End Select
        'Sleep
        Select Case CheckBox5.CheckState
            Case CheckState.Checked
                sleep = 16
            Case CheckState.Unchecked
                sleep = 0
        End Select
        'Silence
        Select Case CheckBox6.CheckState
            Case CheckState.Checked
                silence = 32
            Case CheckState.Unchecked
                silence = 0
        End Select
        'Check
        Select Case CheckBox7.CheckState
            Case CheckState.Checked
                check = 64
            Case CheckState.Unchecked
                check = 0
        End Select
        'GrantAdmin
        Select Case CheckBox8.CheckState
            Case CheckState.Checked
                grant = 128
            Case CheckState.Unchecked
                grant = 0
        End Select
        'Map 
        Select Case CheckBox9.CheckState
            Case CheckState.Checked
                map = 256
            Case CheckState.Unchecked
                map = 0
        End Select
        'Skill 
        Select Case CheckBox10.CheckState
            Case CheckState.Checked
                skill = 512
            Case CheckState.Unchecked
                skill = 0
        End Select
        'build
        Select Case CheckBox11.CheckState
            Case CheckState.Checked
                build = 1024
            Case CheckState.Unchecked
                build = 0
        End Select
        'Announce 
        Select Case CheckBox12.CheckState
            Case CheckState.Checked
                anounce = 2048
            Case CheckState.Unchecked
                anounce = 0
        End Select
        'Warn
        Select Case CheckBox13.CheckState
            Case CheckState.Checked
                warn = 4096
            Case CheckState.Unchecked
                warn = 0
        End Select
        'AllChat
        Select Case CheckBox14.CheckState
            Case CheckState.Checked
                allchat = 8192
            Case CheckState.Unchecked
                allchat = 0
        End Select
        'Invisible 
        Select Case CheckBox15.CheckState
            Case CheckState.Checked
                invisible = 16384
            Case CheckState.Unchecked
                invisible = 0
        End Select
        'Cheats
        Select Case CheckBox16.CheckState
            Case CheckState.Checked
                cheats = 32768
            Case CheckState.Unchecked
                cheats = 0
        End Select
        'AmWhois
        Select Case CheckBox17.CheckState
            Case CheckState.Checked
                whois = 65536
            Case CheckState.Unchecked
                whois = 0
        End Select
        'Merc + Empo
        Select Case CheckBox18.CheckState
            Case CheckState.Checked
                merc = 131072
            Case CheckState.Unchecked
                merc = 0
        End Select
        'Shake 
        Select Case CheckBox19.CheckState
            Case CheckState.Checked
                shake = 262144
            Case CheckState.Unchecked
                shake = 0
        End Select
        'Effect
        Select Case CheckBox20.CheckState
            Case CheckState.Checked
                effect = 524288
            Case CheckState.Unchecked
                effect = 0
        End Select
        'ForceTeam
        Select Case CheckBox21.CheckState
            Case CheckState.Checked
                forceteam = 1048576
            Case CheckState.Unchecked
                forceteam = 0
        End Select
        'Weather
        Select Case CheckBox22.CheckState
            Case CheckState.Checked
                weather = 2097152
            Case CheckState.Unchecked
                weather = 0
        End Select
        'Status
        Select Case CheckBox23.CheckState
            Case CheckState.Checked
                status = 4194304
            Case CheckState.Unchecked
                status = 0
        End Select
        'REname
        Select Case CheckBox24.CheckState
            Case CheckState.Checked
                rename = 8388608
            Case CheckState.Unchecked
                rename = 0
        End Select
        'Faction management
        Select Case CheckBox25.CheckState
            Case CheckState.Checked
                faction = 16777216
            Case CheckState.Unchecked
                faction = 0
        End Select
        'Credit management
        Select Case CheckBox26.CheckState
            Case CheckState.Checked
                credits = 33554432
            Case CheckState.Unchecked
                credits = 0
        End Select
        'Item Management 
        Select Case CheckBox27.CheckState
            Case CheckState.Checked
                item = 67108864
            Case CheckState.Unchecked
                item = 0
        End Select
        'AmAudio
        Select Case CheckBox28.CheckState
            Case CheckState.Checked
                audio = 134217728
            Case CheckState.Unchecked
                audio = 0
        End Select
        'Bounty management
        Select Case CheckBox29.CheckState
            Case CheckState.Checked
                bounty = 268435456
            Case CheckState.Unchecked
                bounty = 0
        End Select
        'ToBlack
        Select Case CheckBox30.CheckState
            Case CheckState.Checked
                toblack = 536870912
            Case CheckState.Unchecked
                toblack = 0
        End Select
        'Training 
        Select Case CheckBox31.CheckState
            Case CheckState.Checked
                training = 1073741824
            Case CheckState.Unchecked
                training = 0
        End Select
        'GunItemGive
        Select Case CheckBox32.CheckState
            Case CheckState.Checked
                gunitem = 2147483648
            Case CheckState.Unchecked
                gunitem = 0
        End Select
        endvalue = kick + ban + tele + search + sleep + silence + check + grant + map + skill + allchat
        endvalue1 = invisible + cheats + whois + merc + shake + effect + forceteam + weather + build + anounce + warn
        endvalue2 = status + rename + faction + credits + item
        endvalue3 = audio + bounty + toblack + training + gunitem
        totalvalue = endvalue + endvalue1 + endvalue2
        TextBox1.Text = "set " & ComboBox1.Text & " " & totalvalue


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Captions
        ComboBox1.Text = "openrp_admin1Bitvalues"
        Me.Text = "OpenRP_Bit_Val_Calculator"
        CheckBox1.Text = "Kick"
        CheckBox2.Text = "Ban"
        CheckBox3.Text = "Teleport"
        CheckBox4.Text = "Search"
        CheckBox5.Text = "Sleep"
        CheckBox6.Text = "Silence"
        CheckBox7.Text = "CheckStats"
        CheckBox8.Text = "GrantAdmin"
        CheckBox9.Text = "Map"
        CheckBox10.Text = "Skill"
        CheckBox11.Text = "Build"
        CheckBox12.Text = "Announce"
        CheckBox13.Text = "Warn"
        CheckBox14.Text = "Allchat"
        CheckBox15.Text = "Invisible"
        CheckBox16.Text = "Cheats"
        CheckBox17.Text = "AmWhoIs"
        CheckBox18.Text = "Merc & Empower"
        CheckBox19.Text = "AmShake"
        CheckBox20.Text = "AmEffect"
        CheckBox21.Text = "AmForceTeam"
        CheckBox22.Text = "AmWeather"
        CheckBox23.Text = "AmStatus"
        CheckBox24.Text = "AmRename"
        CheckBox25.Text = "Faction"
        CheckBox26.Text = "Credits"
        CheckBox27.Text = "Item"
        CheckBox28.Text = "AmAudio"
        CheckBox29.Text = "Bounty"
        CheckBox30.Text = "AmToBlack"
        CheckBox31.Text = "AmTrainingSaber"
        CheckBox32.Text = "GunItemGive"
        Button1.Text = "Calculate"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
