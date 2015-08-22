console.log('Task 1: Write functions for working with shapes in standard Planar coordinate system. Points are represented by coordinates P(X, Y) Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2)) Calculate the distance between two points. Check if three segment lines can form a triangle.');

function Line(p1, p2) {
    this.p1 = p1;
    this.p2 = p2;
}

function Point(x, y) {
    this.x = x;
    this.y = y;
    this.distanceToOtherPoint = function (otherPoint) {
        var distX = this.x - otherPoint.x,
            distY = this.y - otherPoint.y,
            distance = Math.sqrt(distX * distX + distY * distY);

        return distance;
    }
}

function isTriangle(line1, line2, line3) {
    var line1Length = line1.p1.distanceToOtherPoint(line1.p2),
        line2Length = line2.p1.distanceToOtherPoint(line2.p2),
        line3Length = line3.p1.distanceToOtherPoint(line3.p2);

    return line1Length + line2Length > line3Length &&
            line1Length + line3Length > line2Length &&
            line2Length + line3Length > line1Length;
}

var a = new Point(2, 1),
    b = new Point(14, 1),
    c = new Point(7, 8),
    ab = new Line(a, b),
    bc = new Line(b, c),
    ac = new Line(c, a);

console.log('AB length is: ' + a.distanceToOtherPoint(b));
console.log('BC length is: ' + b.distanceToOtherPoint(c));
console.log('AC length is: ' + a.distanceToOtherPoint(c));
console.log('Triangle AB BC CA exists? - ' + isTriangle(ab, bc, ac));