using Android.Widget;
using CrossVideoPlayer.FormsPlugin.Abstractions;
using CrossVideoPlayer.FormsPlugin.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using View = Xamarin.Forms.View;

[assembly: ExportRenderer(typeof(CrossVideoPlayerView), typeof(CrossVideoPlayerViewRenderer))]

namespace CrossVideoPlayer.FormsPlugin.Droid
{
    /// <summary>
    /// CrossVideoPlayer Renderer for Android.
    /// </summary>
    public class CrossVideoPlayerViewRenderer : ViewRenderer
    {

        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            var crossVideoPlayerView = Element as CrossVideoPlayerView;

            if ((crossVideoPlayerView != null) && (e.OldElement == null))
            {
                var metrics = Resources.DisplayMetrics;

                crossVideoPlayerView.HeightRequest = metrics.WidthPixels/metrics.Density/crossVideoPlayerView.VideoScale;

                var videoView = new VideoView(Context);

                var uri = Android.Net.Uri.Parse(crossVideoPlayerView.VideoSource);

                videoView.SetVideoURI(uri);

                var mediaController = new MediaController(Context);

                mediaController.SetAnchorView(videoView);

                videoView.SetMediaController(mediaController);

                videoView.Start();

                SetNativeControl(videoView);
            }
        }
    }
}