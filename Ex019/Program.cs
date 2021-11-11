// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
int x = -1;
int y = 2;
if (x > 0 & y > 0) {System.Console.WriteLine("first quart");}
if (x > 0 & y < 0) {System.Console.WriteLine("second quart");}
if (x < 0 & y < 0) {System.Console.WriteLine("third quart");}
if (x < 0 & y > 0) {System.Console.WriteLine("fourth quart");}