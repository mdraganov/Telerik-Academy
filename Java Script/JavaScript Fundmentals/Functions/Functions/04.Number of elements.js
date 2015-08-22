function countDivs() {
    var divs = document.getElementsByTagName('div'),
        count = divs.length;

    document.getElementById('result4').innerHTML = 'The div count is: ' + count;
}