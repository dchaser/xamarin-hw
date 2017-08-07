using System;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace HelloWorld.MarkUpExtensions
{
    [ContentProperty("ResourceId")]
    public class EmbeddedImage : IMarkupExtension
    {
        public string ResourceId { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (String.IsNullOrWhiteSpace(ResourceId))
                return null;
            
            return Xamarin.Forms.ImageSource.FromResource(ResourceId);
        }
    }
}
