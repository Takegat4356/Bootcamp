let statuses = [4, 3, 1, 2, 4, 1]
let names = ['John','Gary','Lisa','Sarah','Bob', 'LaJuana']

for (let counter = 0; counter < statuses.length; counter++){
    let status = getStatus (statuses[counter]);
    writeStatus(names [counter] + " has a status of " + status);    
}

//we want to pass our dependencies (statusNumber) into our method
function getStatus(statusNumber){
    let status = "";
    if (statusNumber === 1){
            status = "Alive";        
    } else if (statusNumber === 2) {
            status = "Zombie";
    } else if (statusNumber === 3) {
            status = "Dead";
    } else {
            status = "Unknown";
    }
return status;
}

function writeStatus(value){
    console.log(value);
}