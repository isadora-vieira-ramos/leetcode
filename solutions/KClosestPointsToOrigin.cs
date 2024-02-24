using System.Linq;

public class KClosestPointsToOrigin {
    public int[][] KClosest(int[][] points, int k) {
        var list = points.ToList();

        var orderedList = list.OrderBy(array =>
        Math.Sqrt((array[0] * array[0]) + (array[1] * array[1]))).Take(k);

        return orderedList.ToArray();
    }
}
