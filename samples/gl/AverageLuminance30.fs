
//--------------------------------------------------------------------------------------
//
// Author:      QUALCOMM, Advanced Content Group - Adreno SDK
//
//               Copyright (c) 2013 QUALCOMM Technologies, Inc. 
//                         All Rights Reserved. 
//                      QUALCOMM Proprietary/GTDR
//--------------------------------------------------------------------------------------




//--------------------------------------------------------------------------------------
// The vertex shader
//--------------------------------------------------------------------------------------

#version 300 es

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



uniform sampler2D g_ColorTexture;
uniform vec2 g_StepSize;
in vec2 g_TexCoord;

out vec4 g_FragColor;

void main()
{
    float fSum = 0.0;
    
    vec2 StepSize = g_StepSize;

	fSum  = texture( g_ColorTexture, g_TexCoord + vec2( 1.5 * StepSize.x, 1.5 * StepSize.y)).r;
	fSum += texture( g_ColorTexture, g_TexCoord + vec2( 0.5 * StepSize.x, 1.5 * StepSize.y)).r;
	fSum += texture( g_ColorTexture, g_TexCoord + vec2(-0.5 * StepSize.x, 1.5 * StepSize.y)).r;
	fSum += texture( g_ColorTexture, g_TexCoord + vec2(-1.5 * StepSize.x, 1.5 * StepSize.y)).r;

	fSum += texture( g_ColorTexture, g_TexCoord + vec2( 1.5 * StepSize.x, 0.5 * StepSize.y)).r;
	fSum += texture( g_ColorTexture, g_TexCoord + vec2( 0.5 * StepSize.x, 0.5 * StepSize.y)).r;
	fSum += texture( g_ColorTexture, g_TexCoord + vec2(-0.5 * StepSize.x, 0.5 * StepSize.y)).r;
	fSum += texture( g_ColorTexture, g_TexCoord + vec2(-1.5 * StepSize.x, 0.5 * StepSize.y)).r;

	fSum += texture( g_ColorTexture, g_TexCoord + vec2( 1.5 * StepSize.x,-0.5 * StepSize.y)).r;
	fSum += texture( g_ColorTexture, g_TexCoord + vec2( 0.5 * StepSize.x,-0.5 * StepSize.y)).r;
	fSum += texture( g_ColorTexture, g_TexCoord + vec2(-0.5 * StepSize.x,-0.5 * StepSize.y)).r;
	fSum += texture( g_ColorTexture, g_TexCoord + vec2(-1.5 * StepSize.x,-0.5 * StepSize.y)).r;

	fSum += texture( g_ColorTexture, g_TexCoord + vec2( 1.5 * StepSize.x,-1.5 * StepSize.y)).r;
	fSum += texture( g_ColorTexture, g_TexCoord + vec2( 0.5 * StepSize.x,-1.5 * StepSize.y)).r;
	fSum += texture( g_ColorTexture, g_TexCoord + vec2(-0.5 * StepSize.x,-1.5 * StepSize.y)).r;
	fSum += texture( g_ColorTexture, g_TexCoord + vec2(-1.5 * StepSize.x,-1.5 * StepSize.y)).r;
	
	// Average
	fSum *= (1.0 / (16.0));
	
 	g_FragColor = vec4(fSum, fSum, fSum, fSum);
}
