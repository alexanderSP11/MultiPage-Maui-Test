namespace MultiPageTestMaui
{
    internal class TestMultiPage : MultiPage<Page>
    {
        public TestMultiPage()
        {
            var children = new List<string>
            {
                "page1", "page2"
            };

            ItemsSource = children;
        }

        protected override Page CreateDefault(object item)
        {
            var text = (string)item;

            var p = new ContentPage();
            p.Content = new Label()
            {
                Text = text,
                VerticalOptions = LayoutOptions.Fill,
                HorizontalOptions = LayoutOptions.Fill,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                BackgroundColor = Colors.Aqua,
            };

            return p;
        }

        protected override void LayoutChildren(double x, double y, double width, double height)
        {
            base.LayoutChildren(x, y, width, height);

            Children[0].Layout(new Rect(x + 10, y + 10, width - 20, height / 2 - 20));
            Children[1].Layout(new Rect(x + 10, y + height / 2 + 10, width - 20, height / 2 - 20));
        }
    }
}