let statuses = [4, 3, 1, 2, 4, 1]
let names = ['John','Gary','Lisa','Sarah','Bob', 'LaJuana']

let counter = 0;
for (let counter = 0; counter < statuses.length; counter++){
    let status = "";
    if (statuses [counter] === 1){
        status = "Alive";        
} else if (statuses [counter] === 2) {
        status = "Zombie";
} else if (statuses [counter] === 3) {
        status = "Dead";
} else {
        status = "Unknown";
}
    console.log(names [counter] + " has a status of " + status);    
}







