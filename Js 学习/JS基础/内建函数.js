
// 1.eval

// var str1 = "1 + 1";
// console.log(eval(str1));
// var str2 = "1+'b'";
// console.log(eval(str2));

// 2.isFinite 返回一个对象是否是一个有限数值,如果是无穷大或者无穷小或者不是数字返回false,其他返回true
console.log(isFinite("xxxxx"));
console.log(isFinite(123111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111112222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222211111));

// 3.isNan 判断一个值是否是数字,是返回false,不是返回true
// console.log(isNaN("1111"));
// console.log(isNaN(1111));

// 4.parseFloat 解析一个字符串,并返回一个浮点数(会自动四舍五入)

var strToFloat = "12345.124900000000000000000000000000000000000000000";
// console.log(parseFloat(strToFloat));

// 5.parseInt,解析一个字符串并返回一个整数，第二个参数是把要转化的参数看成什么进制
// var strToInt = "1234";
// console.log(parseInt(strToInt,10));

// encodeURL and decodeURL
// encodeURLComponent and decodeURLComponent
// 对指定的URL进行编码，对编码过的URL进行解码,是成对出现的
var encodeURLStr = encodeURIComponent("http://username:password@www.example.com:80/path/to/file.php?foo=316&bar=this+has+spaces#anchor");
console.log(encodeURLStr);

console.log("1"+"2");
console.log(eval("1+2"));
