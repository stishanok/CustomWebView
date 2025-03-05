using MauiCustomWebView.Helpers;

namespace MauiCustomWebView.Views
{
    public partial class TextEditorView : ContentView
    {
        public TextEditorView()
        {
            InitializeComponent();
            InitializeQuillEditor();
        }

        private void InitializeQuillEditor()
        {
            var html = ResourceLoader.GetEmbeddedResourceString("MauiCustomWebView.Resources.Raw.TextEditor.quill-text-editor.html");
            var css = ResourceLoader.GetEmbeddedResourceString("MauiCustomWebView.Resources.Raw.TextEditor.quill-text-editor.css");
            var js = ResourceLoader.GetEmbeddedResourceString("MauiCustomWebView.Resources.Raw.TextEditor.quill-text-editor.js");

            var source = html.Replace("/* quill_style */", css).Replace("/* quill_script */", js);

            QuillWebView.Source = new HtmlWebViewSource { Html = source };
        }
    }
}
