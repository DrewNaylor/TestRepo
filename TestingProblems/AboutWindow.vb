'Git Problem Testing - Test Git Line Ending Problems.
'Copyright(C) 2016+  Drew Naylor
'
'I did not make Git nor GitHub; this is simply a program 
'to test for line ending problems with Git. It's meant to
'be placed in a Git repo, cloned, then built. If any text
'has issues with layout, Git might have a problem.
'
'This file is part Of Git Problem Testing.
'
'Git Problem Testing is free software: you can redistribute it and/or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.
'
'Git Problem Testing is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty Of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.
'
'You should have received a copy Of the GNU General Public License
'along with Git Problem Testing.  If not, see <http://www.gnu.org/licenses/>.





Public Class AboutWindow

    'Go to my GitHub profile page.
    Private Sub GithubLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GithubLinkLabel.LinkClicked
        Process.Start("https://github.com/DrewNaylor")
    End Sub

    'Go to the Gnu GPL webpage.
    Private Sub GPLLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GPLLinkLabel.LinkClicked
        Process.Start("http://www.gnu.org/copyleft/gpl")
    End Sub

    'Close window.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class