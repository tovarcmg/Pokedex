namespace MauiApp2;

public partial class Cartas : ContentPage
{
    public Cartas()
    {
        InitializeComponent();

    }

    private void DragGestureRecognizer_DragStarting_1(object sender, DragStartingEventArgs e)
    {
        
        // var label = (sender as Element)?.Parent as Label;
        // e.Data.Properties.Add("Text", label.Text);
    }

    private void DropGestureRecognizer_Drop_1(object sender, DropEventArgs e)
    {
        // var data = e.Data.Properties["Text"].ToString();
        // var frame = (sender as Element)?.Parent as Entry;
        // frame.Text = data;
    }
}