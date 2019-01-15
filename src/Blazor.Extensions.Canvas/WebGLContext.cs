namespace Blazor.Extensions.Canvas
{
    public class WebGLContext : RenderingContext
    {
        #region Constants
        private const string CONTEXT_NAME = "WebGL";
        private const string CLEAR_COLOR = "clearColor";
        private const string CLEAR = "clear";
        #endregion

        internal WebGLContext(BECanvasComponent canvasReference) : base(canvasReference, CONTEXT_NAME)
        {
        }

        #region Methods
        public void ClearColor(float red, float green, float blue, float alpha) => this.CallMethod<object>(CLEAR_COLOR, new object[] { red, green, blue, alpha });
        public void Clear(BufferBits mask) => this.CallMethod<object>(CLEAR, new object[] {mask});
        #endregion
    }
}
