using System;
class WoodenRod{
    private int length;
    private int[] prices;
    public WoodenRod(int length, int[] prices){
        this.length = length;
        this.prices = prices;
    }
    public int GetLength(){
        return length;
    }
    public int[] GetPrices(){
        return prices;
    }
}
