export default function SubroleOptions(role){
    if(role == 1){
        return `
        <button class='subRoleOption' value='1'>Controlling the flow of the game by inhibiting my opponent(s) actions.</button>
        <button class='subRoleOption' value='2'>Creating opportunies by capitalizing on my enemies mistakes.</button>
        
        `
    }
    else if(role == 2){
        return `
        <button class='subRoleOption' value='1'>Focusing entirely on supporting others.</button>
        <button class='subRoleOption' value='2'>Being able to support others, but also filling other roles as needed.</button>
        `
    }
    else if(role == 3){
        return `
        <button class='subRoleOption' value='1'>Keeping distance between myself and enemy while dealing consistent damage.</button>
        <button class='subRoleOption' value='2'>Moving into enemy territory to pick off specific targets.</button>
        <button class='subRoleOption' value='3'>Creating opportunities to deal large amounts of damage in a short time frame.</button>
        `
    }

}