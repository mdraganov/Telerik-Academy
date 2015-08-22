var i,
    charArr1 = ['a', 'b', 'e', 'f', 's', 'f'],
    charArr2 = ['c', 'g', 'd', 'z', 's'],
    len = charArr1.length;

console.log('\nTask 2: Write a script that compares two char arrays lexicographically (letter by letter).');

if (charArr1.length > charArr2.length) len = charArr2.length;

for (i = 0; i < len; i += 1) {
    if (charArr1[i] > charArr2[i]) console.log(charArr1[i] + '>' + charArr2[i]);
    else if (charArr1[i] == charArr2[i]) console.log(charArr1[i] + '=' + charArr2[i]);
    else console.log(charArr1[i] + '<' + charArr2[i]);
}