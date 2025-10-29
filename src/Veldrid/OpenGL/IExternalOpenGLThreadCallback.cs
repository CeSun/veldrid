using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Veldrid.OpenGL
{
    public interface IExternalOpenGLThreadCallback
    {
        public event Action OnOpenGLThreadExcecute;

        public event Action<uint> OnSetOpenGLFramebuffer;

        public event Action<Size> OnFrameBufferSizeChanged;
    }
}
