var context = document.getElementById('theCanvas').getContext('2d');

context.beginPath();
context.fillStyle = 'rgb(156, 83, 83)';
context.strokeStyle = 'rgb(0, 0, 0)';
context.lineWidth = 3;
context.rect(500, 300, 400, 300);
context.lineTo(700, 100);
context.lineTo(900, 300);
context.fill();
context.stroke();

context.translate(500, 300);
context.fillStyle = 'rgb(0, 0, 0)';
context.fillRect(25, 30, 70, 45);
context.fillRect(25, 78, 70, 45);
context.fillRect(98, 30, 70, 45);
context.fillRect(98, 78, 70, 45);

context.translate(207, 0);
context.fillRect(25, 30, 70, 45);
context.fillRect(25, 78, 70, 45);
context.fillRect(98, 30, 70, 45);
context.fillRect(98, 78, 70, 45);

context.translate(0, 130);
context.fillRect(25, 30, 70, 45);
context.fillRect(25, 78, 70, 45);
context.fillRect(98, 30, 70, 45);
context.fillRect(98, 78, 70, 45);

context.translate(-207, -130);
//context.lineCap = "round";
context.moveTo(45, 300);
context.lineTo(45, 190);
context.bezierCurveTo(45, 175, 75, 163, 96.5, 163);
context.bezierCurveTo(118, 163, 148, 175, 148, 190);
context.lineTo(148, 300);
context.moveTo(96.5, 300);
context.lineTo(96.5, 163);
context.stroke();

context.beginPath();
context.arc(113, 258, 6, 0, 360 * Math.PI / 180);
context.stroke();

context.beginPath();
context.arc(80, 258, 6, 0, 360 * Math.PI / 180);
context.stroke();

context.beginPath();
context.fillStyle = 'rgb(156, 83, 83)';
context.moveTo(280, -40);
context.lineTo(280, -150);
context.lineTo(320, -150);
context.lineTo(320, -40);
context.fill();
context.stroke();

context.beginPath();
context.scale(1, 0.3);
context.arc(300, -500, 20, 0, 360 * Math.PI / 180);
context.fill();
context.stroke();
context.restore();
