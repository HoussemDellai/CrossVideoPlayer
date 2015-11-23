using CrossVideoPlayer.FormsPlugin.Abstractions;
using Xamarin.Forms;
using CrossVideoPlayer.FormsPlugin.iOSUnified;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CrossVideoPlayerView), typeof(CrossVideoPlayerRenderer))]

namespace CrossVideoPlayer.FormsPlugin.iOSUnified
{
    /// <summary>
    /// (Not implemented) CrossVideoPlayer Renderer for iOS.
    /// </summary>
    public class CrossVideoPlayerRenderer : ViewRenderer
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init()
        {

        }
    }
}
