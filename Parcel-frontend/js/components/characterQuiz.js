export default function CharacterQuiz(){
return `

<div class=Question_Container>
    <div class=Question_Head>
        <h2>How would you describe your level of experience with video games?</h2>
    </div>
    <div class=Question_Choices>
        <button class='option' value='1'>I have little to no experience with video games.</button>
        <button class='option' value='2'>I have some experience with video games.</button>
        <button class='option' value='3'>I have a lot of experience with video games.</button>
    </div>
</div>

<div class=Question_Container>
    <div class=Question_Head>
        <h2>Which of these roles would be most appealing to you?</h2>
    </div>
    <div class=Question_Choices>
        <button class='option' value='1'>A lead role, where I decide the direction the team is headed.</button>
        <button class='option' value='2'>A supportive role, where I help others persform their roles optimally.</button>
        <button class='option' value='3'>A damage role, where I focus on taking down a specific enemy.</button>
    </div>
</div>

<div class=Question_Container>
    <div class=Question_Head>
        <h2>Within this role, which of these styles are more appealing?</h2>
    </div>
    <div class=Question_Choices>
        <button class='option' value='1'>Controlling the flow of the game by inhibiting my opponent(s) actions.</button>
        <button class='option' value='2'>Creating opportunies by capitalizing on my enemies mistakes.</button>
    </div>
</div>
`
}