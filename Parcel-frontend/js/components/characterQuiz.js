export default function CharacterQuiz(gameId){
return `
<div class="entireQuestionBox">
    <header id="quizHeader">
     <h1>Find Your Hero</h1>
    </header>


    <div class="Question_Container" id="questionCon1">
        <button class="Question_Head">
            <h2>How would you describe your level of experience with video games?</h2>
        </button>
        <div class="Question_Choices" value='1' id="answerHolder1">
            <button class='quiz-button diffOption' value='1' id='opt1Ans1'>I have little to no experience with video games.</button>
            <button class='quiz-button diffOption' value='2' id='opt1Ans2'>I have some experience with video games.</button>
            <button class='quiz-button diffOption' value='3' id='opt1Ans3'>I have a lot of experience with video games.</button>
        </div>
    </div>

    <div class="Question_Container " id="questionCon2">
        <div class="Question_Head">
            <h2>Which of these roles would be most appealing to you?</h2>
        </div>
        <div class="Question_Choices" value='2' id="answerHolder2">
            <button class='quiz-button roleOption' value='1' id="opt2Ans1">A lead role, where I decide the direction the team is headed.</button>
            <button class='quiz-button roleOption' value='2' id="opt2Ans2">A damage role, where I focus on taking down a specific enemy.</button>
            <button class='quiz-button roleOption' value='3' id="opt2Ans3">A supportive role, where I help others perform their roles optimally.</button>
        </div>
    </div>

    <div class="Question_Container">
        <div class=Question_Head>
            <h2>Within this role, which of these styles is most appealing?</h2>
        </div>
        <div class="Question_Choices" id='subroleOptions' value='3'>
            <p>Please select a role before answering this question.</p>
            </div>
        </div>
        
    <div class="Question_Container" id=optional>
        </div>
            <div id = "submit">
            <button class='quiz-button submit-button'>Submit</button>
        </div>
    <input id='charquiz_gameId' style='display:none' value = ${gameId}>  
</div>

`
}