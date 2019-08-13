export default function SubroleOptions(role){
    if(role == 1){
        return `
        <button class='quiz-button subRoleOption' value='1'><img src="https://i.imgur.com/ogHhroG.png"> Controlling the flow of the game by inhibiting my opponent(s) actions.</button>
        <button class='quiz-button subRoleOption' value='2'><img src="https://i.imgur.com/9a17yBu.png"> Creating opportunies by capitalizing on my enemies mistakes.</button>
        
        `
    }
    else if(role == 2){
        return `
        <button class='quiz-button subRoleOption' value='1'><img src="https://i.imgur.com/vP33MCf.png"> Keeping distance between myself and enemy while dealing consistent damage.</button>
        <button class='quiz-button subRoleOption' value='2'><img src="https://i.imgur.com/9JJfC1S.png"> Moving into enemy territory to pick off specific targets.</button>
        <button class='quiz-button subRoleOption' value='3'><img src="https://i.imgur.com/iAIFaEI.png"> Creating opportunities to deal large amounts of damage in a short time frame.</button>
        `
    }
    else if(role == 3){
        return `
        <button class='quiz-button subRoleOption' value='1'><img src="https://i.imgur.com/1iB5mvO.png"> Focusing entirely on supporting others.</button>
        <button class='quiz-button subRoleOption' value='2'><img src="https://i.imgur.com/BOJgpsu.png"> Being able to support others, but also filling other roles as needed.</button>
        `
    }

}