using System;
class Rod{
    private int length;
    private int[] prices;
    public Rod(int length, int[] prices){
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
