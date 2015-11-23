using System;
using System.Windows.Controls;
using CrossVideoPlayer.FormsPlugin.Abstractions;
using Xamarin.Forms;
using CrossVideoPlayer.FormsPlugin.WindowsPhone;
using Xamarin.Forms.Platform.WinPhone;

[assembly: ExportRenderer(typeof(CrossVideoPlayerView),
                          typeof(CrossVideoPlayerViewRenderer))]

namespace CrossVideoPlayer.FormsPlugin.WindowsPhone
{
    /// <summary>
    /// CrossVideoPlayer Renderer for Windows Phone Silverlight.
    /// </summary>
    public class CrossVideoPlayerViewRenderer : ViewRenderer
    {

        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init()
        {
        }

        /// <summary>
        /// Reload the view and hit up the MediaElement. 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {

            base.OnElementChanged(e);

            var crossVideoPlayerView = Element as CrossVideoPlayerView;

            if ((crossVideoPlayerView != null) && (e.OldElement == null))
            {

                var mediaElement = new MediaElement
                {
                    Source = new Uri(crossVideoPlayerView.VideoSource),
                    AutoPlay = true,
                    Width = 480, // TODO: figure a better way to set the right Width of the current view
                    Height = 480 / crossVideoPlayerView.VideoScale,
                };

                crossVideoPlayerView.WidthRequest = mediaElement.Width;
                crossVideoPlayerView.HeightRequest = mediaElement.Height;

                Children.Add(mediaElement);
            }
        }
    }
}
