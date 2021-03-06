//--------------------------------------------------------------------------------------
// File: Textured.glsl
// Desc: Shaders for a single-textured object
//
// Author:                 QUALCOMM, Adreno SDK
//
//               Copyright (c) 2013 QUALCOMM Technologies, Inc. 
//                         All Rights Reserved. 
//                      QUALCOMM Proprietary/GTDR
//--------------------------------------------------------------------------------------


//--------------------------------------------------------------------------------------
// The vertex shader
//--------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------
// File: CommonFS.glsl
// Desc: Useful common shader code for fragment shaders
//
// Author:                 QUALCOMM, Adreno SDK
//
//               Copyright (c) 2013 QUALCOMM Technologies, Inc. 
//                         All Rights Reserved. 
//                      QUALCOMM Proprietary/GTDR
//--------------------------------------------------------------------------------------

// default to medium precision
precision mediump float;

// OpenGL ES require that precision is defined for a fragment shader
// usage example: varying NEED_HIGHP vec2 vLargeTexCoord;
#ifdef GL_FRAGMENT_PRECISION_HIGH
   #define NEED_HIGHP highp
#else
   #define NEED_HIGHP mediump
#endif

// Enable supported extensions
#extension GL_OES_texture_3D : enable


// Define some useful macros
#define saturate(x) clamp( x, 0.0, 1.0 )
#define lerp        mix



uniform sampler2D g_DiffuseSampler;

varying vec4 Frag_Position;
varying vec2 Frag_TexCoord;


//--------------------------------------------------------------------------------------
// Fragment shader entry point
//--------------------------------------------------------------------------------------
void main()
{
	vec4 vPosition = Frag_Position / Frag_Position.w;

    gl_FragColor = texture2D( g_DiffuseSampler, Frag_TexCoord ); 

	gl_FragColor.a = (1.0 - vPosition.y) - 0.5;
}

