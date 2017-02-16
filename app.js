





// var country = ["pakistan", "india", "UAE", "America", "somalia"];
// var capitals = ["pakistan", "india", "UAE", "America", "somalia"];



// var round = 0;

// var find = function (index, arr) {

//     console.log("-----------------------------------");

//     console.log("round: ", round++);

//     console.log("capital: ", arr);
//     console.log("capital mid: ", Math.floor(arr.length / 2));
//     console.log("index: ", index);

//     //making a copy of capitals array

//     if (Math.floor(arr.length / 2) == index) {
//         // show alert and end up
//         console.log(arr[index]);
//     } else if (arr.length / 2 < index) {

//         arr.splice(0, index);

//         find(Math.floor((index / 2) - 1), arr);

//     } else if (arr.length / 2 > index) {

//     } else {
//         //something is wrong
//     }

// }
// find(3, capitals);

34567


var country = ["pakistan", "india", "UAE", "America", "somalia"];
var capitals = ["pakistan", "india", "UAE", "America", "somalia"];

var find = function (index, start, end, arr) {

    var mid = Math.round((start + end) / 2);

    if (index === mid) {

        console.log(arr[index]);

    } else if (index < mid && arr.length != 0) {

        find(index, start, mid, arr);
    }
}

find(0, 0, capitals.length - 1, capitals);



