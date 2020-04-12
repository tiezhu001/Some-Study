
//1.创建数组
var array1 = new Array(4); //创建一个长度为4的数组
var array3 = Array(4);
var array2 = [4]; //创建一个初始化元素只有一个4的元素

//相等
var array4 = new Array(1, 2, 3, 4);
var array5 = Array(1, 2, 3, 4);
var array6 = [1, 2, 3, 4];

console.log(array1.length, array2.length, array3.length);
console.log(array2[0]);

// 2.遍历数组中的元素

console.log("-----------------------------------");
for (var i = 0; i < array4.length; i++) {
    console.log(array4[i]);
}
console.log("-----------------------------------");
for (var i = 0; i < array5.length; i++) {
    console.log(array5[i]);
}
console.log("-----------------------------------");
for (var i = 0; i < array6.length; i++) {
    console.log(array6[i]);
}

console.log("------------------------------------");


console.log("for in 循环");

// for in 循环和普通的for循环一样遍历的数组的下标
for (var index in array4) {
    console.log(array4[index]);
}

console.log("for of 循环")
// for of 循环遍历的数组的元素
for (var item of array4) {
    console.log(item);
}

console.log("forEach循环");
// foreach遍历
array4.forEach((item) => {
    console.log(item);
});

array4.forEach(function (e) {
    console.log(e);
})

console.log("数组对象的方法");
//4. 数组对象的方法
var array7 = new Array("array1", "array2", "array3");

// 增加元素
// push unshift
console.log("push 方法");
var pushAfterLength = array7.push("array4");  //push在数组的末尾添加一个或者多个元素,并返回添加后数组的长度
for (var item of array7) {
    console.log(item);
}
console.log(pushAfterLength);

console.log("unshift方法");
var unshiftAfterLength = array7.unshift("array5", "array6"); // unshift在数组的开头添加一个或者多个元素,并且返回数组的长度
array7.forEach((element) => {
    console.log(element);
});
console.log(unshiftAfterLength);

//删除元素
// pop shift
console.log("pop 方法");
var popAfterItem = array7.pop(); //从数组的开头删除第一个元素并且返回删除的第一个元素的值
array7.forEach((element) => {
    console.log(element);
});
console.log(popAfterItem);

console.log("shift 方法");
var shiftAfterItem = array7.shift(); //从数组的结尾删除最后一个元素，并且返回删除的元素的值
array7.forEach((element) => {
    console.log(element);
});
console.log(shiftAfterItem);

// concat() 链接两个数组，并返回新的数组
var array8 = new Array("第二个数组");
console.log("concat 方法");
var concatArray = array7.concat(array8);
concatArray.forEach((element) => {
    console.log(element);
});

console.log("sort方法");
// sort 给数组排序
var array9 = new Array("gabc","muq","aaa");
for(var item of array9.sort()){
    console.log(item);
}
console.log("sort传入有个排序的回调函数");
array9.sort((a,b)=>{return b[0]-a[0]});
for(var item in array9){
    console.log(array9[item]);
}
console.log("map函数");
// map函数 数组的每一个元素执行相同的操作，并且返回新的数组
var mapResult = array9.map(function(a){return a.toUpperCase()});
for(var item of mapResult){
console.log(item);
}

// filter 返回回调函数的等于true的新数组
console.log("filter方法");
var filterResult = array9.filter(function(a){return a[0]=="a"});
console.log(filterResult.length);

// 判断数组的每一个元素是否返回条件,true or false
console.log("every方法");
var everyResult = mapResult.every(function(e){ return e.length>1});
console.log(everyResult);

// join 将数组中的每一个元素链接成一个字符串
var joinResult = mapResult.join();  //AAA,GABC,MUQ
var joinResult2 = mapResult.join(" "); // AAA-GABC-MUQ
console.log(joinResult);
console.log(joinResult2);

