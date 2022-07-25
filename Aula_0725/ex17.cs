using System;

class Program {
  public static void Main() {
    Console.WriteLine(MMC(27, 36));
    Console.WriteLine(MMC2(27, 36));
  }
  public static int MMC(int x, int y) {
    int m = x;
    while (!(m % x == 0 && m % y == 0)) m++;
    return m;
    // m é múltiplo de x qdo m % x == 0
    // m é múltiplo de y qdo m % y == 0
  }
  public static int MMC2(int x, int y) {
    return MMC_Rec(x, x, y);
  }
  public static int MMC_Rec(int mmc, int x, int y) {
    if (mmc % x == 0 && mmc % y == 0) return mmc;
    return MMC_Rec(mmc+1, x, y);
  }
  
  
}
