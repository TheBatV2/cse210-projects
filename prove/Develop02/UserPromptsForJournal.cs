using System;

public class UserPromptsForJournal
{
   
    
    private string[] prompts = 
    
    {    

        "When and where were you born? Describe your home, your neighborhood, and the town you grew up in.",
        "What is your full name? Explain why your parents gave you that name.",
        "What memories do you have of your father (his name, birth date, birthplace, parents, and so on)?",
        "What memories do you have of your mother (her name, birth date, birthplace, parents, and so on)?",
        "What kind of work did your parents do (farmer, salesman, manager, seamstress, nurse, stay-at-home mom, professional, laborer, and so on)?",
        "Have any of your family members died? If so, explain what they died from and what you remember of their death; the circumstances of their death.",
        "What kind of hardships or tragedies did your family experience while you were growing up?",
        "Are there any obvious or unusual genetic traits that run in your family line?",
        "What are the names of your brothers and sisters? Describe things that stand out in your mind about each of your siblings.",
        "What were some of your family traditions that you remember?",
        "Did your family have special ways of celebrating specific holidays?",
        "Share some memories of your grandparents.",
        "Did your grandparents live close by? If so, describe how they were involved in your life. If they lived far away share some memories of visiting them or of them traveling to visit you.",
        "Who were your aunts and uncles? Write about any of your aunts or uncles who really stand out in your mind. Give some details about them (names, personalities, events that you remember doing with them, and so on).",
        "Where did you go to school? Give some details about what was school like for you and some of your memorable experiences.",
        "What were your favorite subjects in school? Explain why.",
        "What subjects did you like the least? Explain why.",
        "Who were some of your friends in school? Explain what your friends were like and what they are doing today if you know that.",
        "If you went to college or a vocational school, what school did you attend? Describe what memories you have of those years and what subjects you studied.",
        "What do you see as your greatest strengths?",
        "What were some of the challenges you have had to deal with in your life?",
        "What medical issues have you had to deal with throughout your life?",
        "Was religion an important for you and your family? If so, explain what religion your family practiced and what it meant to you. Explain if it is or is not an important part of your life today.",
        "What foods do you like and dislike? Describe any food allergies you or other family members had.",
        "Were there two or three food dishes your mother or father made that were especially memorable?",
        "How did you meet your spouse?",
        "What was your courtship like? Describe your marriage day.",
        "Share some stories about your spouse.",
        "How many children do you have? List their names and share a few memories about each one.",
        "Describe some of the major community, national, and world events you lived through. How did these events change your life?",
        "What are some of your life philosophies or life views that you would share with others?",
        "What are some of the personal values that are very important to you? Share some examples of what have you done and what are you doing now to teach these values to your children, grandchildren and others.",
        "List at least five people who have had a memorable influence on your life. What did they do that had such an influence on you?",
        "What are 20 things about yourself that make you uniquely you?",
        "What are 50 things that you are grateful for?",
        "What is your philosophy on money?",
        "If you could spend a day with any famous person in the world, who would it be, and what would you do during your day with him or her?",
        "What scares you?",
        "What makes you stop and go “Wow!”?",
        "What are some of the things you enjoy doing in your leisure time?",
        "If you could go back in time and spend an hour visiting with yourself at age 15, what would you tell your younger self?",
        "What are some of your talents? Explain how you discovered them and what you have done to cultivate and improve them. Describe how your talents have they affected your life.",
        "What did you do for a career? Explain how you chose that career.",
        "What were some of the jobs you had throughout your life? Explain some of the memorable experiences you had with these jobs.",
        "What are 5 significant events or experiences in your life, and explain what effects they have had on you.",
        "What are some of the life lessons that you have learned and would like to pass on to your descendants?",
        "In how many places have you lived during your lifetime? Provide a brief description of each place you’ve lived, why you lived there, and why you moved.",
        "If someone gave you $10,000 and told you that you could NOT give it to any of your friends, family members or use it for yourself, what would you do with it?",
        "If you could go back in time and do things over again, what would you change?",
        "When all is said and done, what do you want to be remembered for? Explain what you are doing now to create a legacy worthy of remembering.",
        "If you were to leave 5 different bits of advice for your future posterity, what would they be?",
        "Have you traveled to any place outside of your home country? If so, explain the reasons for your trip(s) and what memorable things happened on some of those trips.",
    };
    public string getPrompt()
    {
        Random randomGenerator = new Random();
        int promptNumber = randomGenerator.Next(0,prompts.Length);
        return prompts[promptNumber];
    
    }
        
}   
    
