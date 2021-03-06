﻿using Microsoft.Xna.Framework.Graphics;

namespace Protogame
{
    /// <summary>
    /// A render pass in which graphics rendering is configured for an
    /// orthographic view.  When this render pass is active, the X and
    /// Y positions of entities map directly to the X and Y positions 
    /// of the game window, with (0, 0) being located in the top-left.
    /// <para>
    /// During this render pass, rendering operations are performed
    /// immediately on the rendering target.  To batch multiple
    /// texture render calls, use an <see cref="I2DBatchedRenderPass" />
    /// instead or in addition to this render pass.
    /// </para>
    /// </summary>
    /// <module>Graphics</module>
    public interface I2DDirectRenderPass : IRenderPass, IRenderPassWithViewport
    {
    }
}

