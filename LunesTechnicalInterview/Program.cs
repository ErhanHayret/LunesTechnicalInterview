using LunesTechnicalInterview;

SumOfTriangle a = new();
int[] dummyInput = { 3, 7, 4, 2, 4, 6, 8, 5, 9, 3 };
int[] input1 = { 1, 8, 4, 2, 6, 9, 8, 5, 9, 3 };
int[] input2 = {215, 193, 124, 117, 237, 442, 218, 935, 347, 235, 320, 804, 522, 417, 345, 229, 601, 723, 835, 133, 124,
    248, 202, 277, 433, 207, 263, 257, 359, 464, 504, 528, 516, 716, 871, 182, 461, 441, 426, 656, 863, 560, 380, 171, 923,
    381, 348, 573, 533, 447, 632, 387, 176, 975, 449, 223, 711, 445, 645, 245, 543, 931, 532, 937, 541, 444, 330, 131, 333,
    928, 377, 733, 017, 778, 839, 168, 197, 197, 131, 171, 522, 137, 217, 224, 291, 413, 528, 520, 227, 229, 928, 223, 626,
    034, 683, 839, 053, 627, 310, 713, 999, 629, 817, 410, 121, 924, 622, 911, 233, 325, 139, 721, 218, 253, 223, 107, 233,
    230, 124, 233
};
var x1 = a.Func(dummyInput);
Console.WriteLine("output of dummy\n" + x1 + "\n");
var x2 = a.Func(input1);
Console.WriteLine("output of input1\n" + x2 + "\n");
var x3 = a.Func(input2);
Console.WriteLine("output\n" + x3 + "\n");

LookAndSay b = new();
b.Func(8, "1");

PossibilityOfAWord c = new();
c.Func("bqrzhxacnv", "erhan");