Public Class DLG_Changelog
    Private Sub DLG_Changelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lb_Changelog.Text =
    "'VERSIONE 2.1.0 - First Release
    
     - Aggiunto funzionalità 'In produzione'
     - Aggiustato le conferme d'ordine
     - Aggiunto modulo 'Modifica Ordine'
     - TreeView e ordini aperti non più in real time
     - DoppioClick su treeview mostra distinta relativa all'ordine selezionato"
    End Sub
End Class