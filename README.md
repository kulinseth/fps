#FPS: *F*unctional *P*rogrammming for *S*hader languages

Design a new language for shaders to run on GPU. During this process, 
different (programming) language design concepts for Graphics and
Compute shading languages will be explored. This repo tracks 
the developement of this language starting from Kernel language 
to experiments of adding various language features. Also, in parallel
compiler will be developed to compile it down to SPIR-V IR format.

The development will be done in following phases:

1. Kernel Language
   
   Choosing a kernel language to start with. This will form the essential
   core of the language. There are some options which can be used. Like the
   core language desribed [here](http://research.microsoft.com/en-us/um/people/simonpj/Papers/pj-lester-book/).
   Or the [FL language](https://en.wikipedia.org/wiki/FL_programming_language) used
   in Tubrak's Design Concepts in Programming Languages book.
   Some other options like [*Tiger*](https://www.lrde.epita.fr/~akim/ccmp/tiger.html) 
   programming language defined in Appel's Modern Compiler Implementation. 

2. Shading Language primitives

   Extending the core Kernel language to include shading computation 
   primitives. The primitives such as **scan**, **reduce** are inspired by work done by 
   [Belloch](https://www.cs.cmu.edu/~blelloch/papers/Ble90.pdf). His work has shown
   how different languages can be mapped to Parallel vector models. He used different
   algorithms/models to map different languages to Parallel vector models.

3. Language extensions

   Different language extensions will be considered depending on the research
   literature. This will happen in parallel with Compiler development to 
   assess implications of different language features.

4. Compiler development

   Compilation flow which will map the Language designed above to 
   [SPIR-V](https://www.khronos.org/registry/spir-v/specs/1.0/SPIRV.pdf) IR 
   format. 

5. Reference examples

   These are examples which will be representative set of GLSL and CL shaders
   which will be used to implement in new Language. The Compiler codegen will
   be compared with Reference implementation's SPIR-V format.


## Motivation

## Design

## Compiler

## Resources
