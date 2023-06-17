﻿Public NotInheritable Class SplashScreen1

    'TODO: このフォームは、プロジェクト デザイナー ([プロジェクト] メニューの下の [プロパティ]) の [アプリケーション] タブを使用して、
    '  アプリケーションのスプラッシュ スクリーンとして簡単に設定することができます

    Friend Sub SetMessage(ByVal msg As String)
        If Not Me.IsDisposed AndAlso Me.IsHandleCreated Then
            If Me.InvokeRequired Then
                Me.Invoke(New EventHandler(AddressOf Me.SetMessagePrivate),                New Object() {msg, Nothing})
            Else
                Me.SetMessagePrivate(msg, Nothing)
            End If
        End If
    End Sub

    Private Sub SetMessagePrivate(ByVal sender As Object, ByVal e As System.EventArgs)
        'System.Windows.Forms.Application.DoEvents()
    End Sub
    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'アプリケーションのアセンブリ情報に従って、ランタイムにダイアログ テキストを設定します。  

        'TODO: [プロジェクト] メニューの下にある [プロジェクト プロパティ] ダイアログの [アプリケーション] ペインで、アプリケーションのアセンブリ情報を 
        '  カスタマイズします

        'アプリケーション タイトル
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'アプリケーション タイトルがない場合は、拡張子なしのアプリケーション名を使用します
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'デザイン時に書式設定文字列としてバージョン管理で設定されたテキストを使用して、バージョン情報の書式を
        '  設定します。これにより効率的なローカリゼーションが可能になります。
        '  ビルドおよび リビジョン情報は、次のコードを使用したり、バージョン管理のデザイン時のテキストを 
        '  "Version {0}.{1:00}.{2}.{3}" のように変更したりすることによって含めることができます。
        '  詳細については、ヘルプの String.Format() を参照してください。
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        '著作権情報
        Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub MainLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainLayoutPanel.Paint

    End Sub

    Private Sub ApplicationTitle_Click(sender As Object, e As EventArgs) Handles ApplicationTitle.Click

    End Sub

    Private Sub SplashScreen1_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub
End Class
