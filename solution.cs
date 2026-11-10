public class Solution {
    public int ActualRank(int n, int r) {
        if (n >= 10) {
            return r;
        } else {
            return -((-100 * (10-n)) - r);
        }
    }
}


// public rank = actual rank if played 10 or more matches
// else:
// public rank is actual rank - 100*(10-k)

// N matches
// Public rank is R

// p = a - 100 * (10-k)
// p - a = -100 * (10-k)
// -a = (-100 * (10-k)) - p)
// a = -((-100 * (10-k)) - p)