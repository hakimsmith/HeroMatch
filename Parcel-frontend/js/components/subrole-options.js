export default function SubroleOptions(role){
    if(role == 1){
        return `
        <button class='quiz-button subRoleOption' id='opt3Ans1' value='1' >Controlling the flow of the game by inhibiting my opponent(s) actions.</button>
        <button class='quiz-button subRoleOption' id='opt3Ans2' value='2'>Creating opportunies by capitalizing on my enemies mistakes.</button>
        
        `
    }
    else if(role == 2){
        return `
        <button class='quiz-button subRoleOption' id='opt3Ans1' value='1'>Keeping distance between myself and enemy while dealing consistent damage.</button>
        <button class='quiz-button subRoleOption' id='opt3Ans2' value='2'>Moving into enemy territory to pick off specific targets.</button>
        <button class='quiz-button subRoleOption' id='opt3Ans3' value='3'>Creating opportunities to deal large amounts of damage in a short time frame.</button>
        `
    }
    else if(role == 3){
        return `
        <button class='quiz-button subRoleOption' id='opt3Ans1' value='1'>Focusing entirely on supporting others.</button>
        <button class='quiz-button subRoleOption' id='opt3Ans2' value='2'>Being able to support others, but also filling other roles as needed.</button>
        `
    }

}