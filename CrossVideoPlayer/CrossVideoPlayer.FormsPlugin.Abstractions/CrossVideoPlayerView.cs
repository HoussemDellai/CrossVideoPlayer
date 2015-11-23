using Xamarin.Forms;

namespace CrossVideoPlayer.FormsPlugin.Abstractions
{
    /// <summary>
    /// CrossVideoPlayerView is a View which contains a MediaElement to play a video.
    /// </summary>
    public class CrossVideoPlayerView : View
    {

        /// <summary>
        /// The url source of the video.
        /// </summary>
        public static readonly BindableProperty VideoSourceProperty =
            BindableProperty.Create<CrossVideoPlayerView, string>(p => p.VideoSource, "");

        /// <summary>
        /// The url source of the video.
        /// </summary>
        public string VideoSource
        {
            get
            {
                return (string)GetValue(VideoSourceProperty);
            }
            set
            {
                SetValue(VideoSourceProperty, value);
            }
        }

        /// <summary>
        /// The scale format of the video which is in most cases 16:9 (1.77) or 4:3 (1.33).
        /// </summary>
        public static readonly BindableProperty VideoScaleProperty =
            BindableProperty.Create<CrossVideoPlayerView, double>(p => p.VideoScale, 1.77);

        /// <summary>
        /// The scale format of the video which is in most cases 16:9 (1.77) or 4:3 (1.33).
        /// </summary>
        public double VideoScale
        {
            get
            {
                return (double)GetValue(VideoScaleProperty);
            }
            set
            {
                SetValue(VideoScaleProperty, value);
            }
        }
    }
}
