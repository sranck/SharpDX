﻿//------------------------------------------------------------------------------
// <auto-generated>
//     SharpDX Toolkit Compiler File Generated:
//     Effect [Toolkit::SpriteEffect]
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SharpDX.Toolkit.Graphics 
{
    public partial class SpriteBatch
    {
        private static readonly SharpDX.Toolkit.Graphics.EffectData effectBytecode = SharpDX.Toolkit.Graphics.EffectData.Load(new byte[] {
84, 75, 70, 88, 74, 7, 0, 0, 83, 72, 68, 82, 4, 7, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 145, 0, 0, 188, 6, 68, 88, 66, 67, 144, 135, 228, 57, 242, 131, 169, 122, 82, 29, 170, 76, 87, 152, 137, 214, 1, 0, 0, 0, 60, 3, 0, 0, 4, 0, 0, 0, 48, 0, 0, 0, 
28, 1, 0, 0, 84, 2, 0, 0, 200, 2, 0, 0, 65, 111, 110, 57, 228, 0, 0, 0, 228, 0, 0, 0, 0, 2, 254, 255, 176, 0, 0, 0, 52, 0, 0, 0, 1, 0, 36, 0, 0, 0, 48, 0, 0, 0, 48, 0, 0, 0, 36, 0, 1, 0, 48, 0, 1, 0, 0, 0, 4, 0, 1, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 254, 255, 31, 0, 0, 2, 5, 0, 0, 128, 0, 0, 15, 144, 31, 0, 0, 2, 5, 0, 1, 128, 1, 0, 15, 144, 31, 0, 0, 2, 5, 0, 2, 128, 2, 0, 15, 144, 5, 0, 0, 3, 0, 0, 15, 128, 2, 0, 85, 144, 2, 0, 228, 160, 
4, 0, 0, 4, 0, 0, 15, 128, 2, 0, 0, 144, 1, 0, 228, 160, 0, 0, 228, 128, 4, 0, 0, 4, 0, 0, 15, 128, 2, 0, 170, 144, 3, 0, 228, 160, 0, 0, 228, 128, 4, 0, 0, 4, 0, 0, 15, 128, 2, 0, 255, 144, 4, 0, 228, 160, 0, 0, 228, 128, 4, 0, 0, 4, 
0, 0, 3, 192, 0, 0, 255, 128, 0, 0, 228, 160, 0, 0, 228, 128, 1, 0, 0, 2, 0, 0, 12, 192, 0, 0, 228, 128, 1, 0, 0, 2, 0, 0, 15, 224, 0, 0, 228, 144, 1, 0, 0, 2, 1, 0, 3, 224, 1, 0, 228, 144, 255, 255, 0, 0, 83, 72, 68, 82, 48, 1, 0, 0, 
64, 0, 1, 0, 76, 0, 0, 0, 89, 0, 0, 4, 70, 142, 32, 0, 1, 0, 0, 0, 4, 0, 0, 0, 95, 0, 0, 3, 242, 16, 16, 0, 0, 0, 0, 0, 95, 0, 0, 3, 50, 16, 16, 0, 1, 0, 0, 0, 95, 0, 0, 3, 242, 16, 16, 0, 2, 0, 0, 0, 101, 0, 0, 3, 
242, 32, 16, 0, 0, 0, 0, 0, 101, 0, 0, 3, 50, 32, 16, 0, 1, 0, 0, 0, 103, 0, 0, 4, 242, 32, 16, 0, 2, 0, 0, 0, 1, 0, 0, 0, 104, 0, 0, 2, 1, 0, 0, 0, 54, 0, 0, 5, 242, 32, 16, 0, 0, 0, 0, 0, 70, 30, 16, 0, 0, 0, 0, 0, 
54, 0, 0, 5, 50, 32, 16, 0, 1, 0, 0, 0, 70, 16, 16, 0, 1, 0, 0, 0, 56, 0, 0, 8, 242, 0, 16, 0, 0, 0, 0, 0, 86, 21, 16, 0, 2, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 1, 0, 0, 0, 50, 0, 0, 10, 242, 0, 16, 0, 0, 0, 0, 0, 
6, 16, 16, 0, 2, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 0, 0, 0, 0, 70, 14, 16, 0, 0, 0, 0, 0, 50, 0, 0, 10, 242, 0, 16, 0, 0, 0, 0, 0, 166, 26, 16, 0, 2, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 2, 0, 0, 0, 70, 14, 16, 0, 
0, 0, 0, 0, 50, 0, 0, 10, 242, 32, 16, 0, 2, 0, 0, 0, 246, 31, 16, 0, 2, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 3, 0, 0, 0, 70, 14, 16, 0, 0, 0, 0, 0, 62, 0, 0, 1, 73, 83, 71, 78, 108, 0, 0, 0, 3, 0, 0, 0, 8, 0, 0, 0, 
80, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 15, 15, 0, 0, 86, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 3, 3, 0, 0, 95, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 
2, 0, 0, 0, 15, 15, 0, 0, 67, 79, 76, 79, 82, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 171, 79, 83, 71, 78, 108, 0, 0, 0, 3, 0, 0, 0, 8, 0, 0, 0, 80, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
3, 0, 0, 0, 0, 0, 0, 0, 15, 0, 0, 0, 86, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 3, 12, 0, 0, 95, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 2, 0, 0, 0, 15, 0, 0, 0, 67, 79, 76, 79, 
82, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 171, 135, 184, 165, 146, 3, 5, 67, 79, 76, 79, 82, 0, 0, 0, 3, 15, 0, 0, 8, 84, 69, 88, 67, 79, 79, 82, 68, 0, 1, 0, 3, 3, 0, 0, 11, 83, 86, 95, 80, 111, 
115, 105, 116, 105, 111, 110, 0, 2, 0, 3, 15, 0, 0, 1, 152, 1, 68, 88, 66, 67, 38, 67, 176, 36, 74, 169, 229, 178, 47, 97, 222, 99, 43, 228, 205, 54, 1, 0, 0, 0, 152, 0, 0, 0, 1, 0, 0, 0, 36, 0, 0, 0, 73, 83, 71, 78, 108, 0, 0, 0, 3, 0, 0, 0, 
8, 0, 0, 0, 80, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 15, 15, 0, 0, 86, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 3, 3, 0, 0, 95, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
3, 0, 0, 0, 2, 0, 0, 0, 15, 15, 0, 0, 67, 79, 76, 79, 82, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 171, 29, 240, 107, 13, 3, 5, 67, 79, 76, 79, 82, 0, 0, 0, 3, 15, 0, 0, 8, 84, 69, 88, 67, 79, 
79, 82, 68, 0, 1, 0, 3, 3, 0, 0, 11, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 2, 1, 3, 15, 0, 0, 0, 0, 0, 0, 0, 1, 16, 80, 114, 111, 106, 101, 99, 116, 105, 111, 110, 77, 97, 116, 114, 105, 120, 64, 1, 15, 77, 97, 116, 114, 105, 120, 84, 114, 97, 
110, 115, 102, 111, 114, 109, 2, 3, 0, 0, 64, 4, 4, 0, 1, 16, 80, 114, 111, 106, 101, 99, 116, 105, 111, 110, 77, 97, 116, 114, 105, 120, 4, 26, 1, 1, 0, 4, 0, 0, 0, 0, 0, 145, 0, 0, 232, 3, 68, 88, 66, 67, 62, 231, 156, 88, 145, 159, 172, 51, 164, 207, 207, 254, 
124, 230, 155, 106, 1, 0, 0, 0, 232, 1, 0, 0, 4, 0, 0, 0, 48, 0, 0, 0, 184, 0, 0, 0, 100, 1, 0, 0, 180, 1, 0, 0, 65, 111, 110, 57, 128, 0, 0, 0, 128, 0, 0, 0, 0, 2, 255, 255, 88, 0, 0, 0, 40, 0, 0, 0, 0, 0, 40, 0, 0, 0, 40, 0, 
0, 0, 40, 0, 1, 0, 36, 0, 0, 0, 40, 0, 0, 0, 0, 0, 0, 2, 255, 255, 31, 0, 0, 2, 0, 0, 0, 128, 0, 0, 15, 176, 31, 0, 0, 2, 0, 0, 0, 128, 1, 0, 3, 176, 31, 0, 0, 2, 0, 0, 0, 144, 0, 8, 15, 160, 66, 0, 0, 3, 0, 0, 15, 128, 
1, 0, 228, 176, 0, 8, 228, 160, 5, 0, 0, 3, 0, 0, 15, 128, 0, 0, 228, 128, 0, 0, 228, 176, 1, 0, 0, 2, 0, 8, 15, 128, 0, 0, 228, 128, 255, 255, 0, 0, 83, 72, 68, 82, 164, 0, 0, 0, 64, 0, 0, 0, 41, 0, 0, 0, 89, 0, 0, 4, 70, 142, 32, 0, 
0, 0, 0, 0, 1, 0, 0, 0, 90, 0, 0, 3, 0, 96, 16, 0, 0, 0, 0, 0, 88, 24, 0, 4, 0, 112, 16, 0, 0, 0, 0, 0, 85, 85, 0, 0, 98, 16, 0, 3, 242, 16, 16, 0, 0, 0, 0, 0, 98, 16, 0, 3, 50, 16, 16, 0, 1, 0, 0, 0, 101, 0, 0, 3, 
242, 32, 16, 0, 0, 0, 0, 0, 104, 0, 0, 2, 1, 0, 0, 0, 69, 0, 0, 9, 242, 0, 16, 0, 0, 0, 0, 0, 70, 16, 16, 0, 1, 0, 0, 0, 70, 126, 16, 0, 0, 0, 0, 0, 0, 96, 16, 0, 0, 0, 0, 0, 56, 0, 0, 7, 242, 32, 16, 0, 0, 0, 0, 0, 
70, 14, 16, 0, 0, 0, 0, 0, 70, 30, 16, 0, 0, 0, 0, 0, 62, 0, 0, 1, 73, 83, 71, 78, 72, 0, 0, 0, 2, 0, 0, 0, 8, 0, 0, 0, 56, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 15, 15, 0, 0, 62, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 3, 3, 0, 0, 67, 79, 76, 79, 82, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 171, 79, 83, 71, 78, 44, 0, 0, 0, 1, 0, 0, 0, 8, 0, 0, 0, 32, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
3, 0, 0, 0, 0, 0, 0, 0, 15, 0, 0, 0, 83, 86, 95, 84, 97, 114, 103, 101, 116, 0, 171, 171, 74, 156, 249, 148, 2, 5, 67, 79, 76, 79, 82, 0, 0, 0, 3, 15, 0, 0, 8, 84, 69, 88, 67, 79, 79, 82, 68, 0, 1, 0, 3, 3, 0, 0, 0, 0, 0, 0, 0, 1, 
9, 83, 86, 95, 84, 97, 114, 103, 101, 116, 0, 0, 64, 3, 15, 0, 0, 0, 0, 0, 0, 0, 1, 10, 80, 97, 114, 97, 109, 101, 116, 101, 114, 115, 0, 0, 3, 14, 84, 101, 120, 116, 117, 114, 101, 83, 97, 109, 112, 108, 101, 114, 4, 10, 0, 1, 7, 84, 101, 120, 116, 117, 114, 101, 
4, 7, 0, 1, 10, 80, 97, 114, 97, 109, 101, 116, 101, 114, 115, 4, 26, 0, 1, 69, 70, 70, 88, 54, 0, 0, 0, 1, 21, 84, 111, 111, 108, 107, 105, 116, 58, 58, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 0, 1, 1, 11, 83, 112, 114, 105, 116, 101, 66, 97, 116, 99, 
104, 1, 0, 0, 0, 1, 6, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 
        });
    }
}
