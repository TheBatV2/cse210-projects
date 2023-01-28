using System;

public class UserPromptsForJournal
{
   
    private List<string> prompts = new List<string>();
    public UserPromptsForJournal()
    {     

        prompts.Add("What is your full name? Explain why your parents gave you that name.");
        prompts.Add("When and where were you born? Describe your home, your neighborhood, and the town you grew up in.");
        prompts.Add("What memories do you have of your father (his name, birth date, birthplace, parents, and so on)?");
        prompts.Add("What memories do you have of your mother (her name, birth date, birthplace, parents, and so on)?");
        prompts.Add("What kind of work did your parents do (farmer, salesman, manager, seamstress, nurse, stay-at-home mom, professional, laborer, and so on)?");
        prompts.Add("Have any of your family members died? If so, explain what they died from and what you remember of their death; the circumstances of their death.");
        prompts.Add("What kind of hardships or tragedies did your family experience while you were growing up?");
        prompts.Add("Are there any obvious or unusual genetic traits that run in your family line?");
        prompts.Add("What are the names of your brothers and sisters? Describe things that stand out in your mind about each of your siblings.");
        prompts.Add("What were some of your family traditions that you remember?");
        prompts.Add("Did your family have special ways of celebrating specific holidays?");
        prompts.Add("Share some memories of your grandparents.");
        prompts.Add("Did your grandparents live close by? If so, describe how they were involved in your life. If they lived far away share some memories of visiting them or of them traveling to visit you.");
        prompts.Add("Who were your aunts and uncles? Write about any of your aunts or uncles who really stand out in your mind. Give some details about them (names, personalities, events that you remember doing with them, and so on).");
        prompts.Add("Where did you go to school? Give some details about what was school like for you and some of your memorable experiences.");
        prompts.Add("What were your favorite subjects in school? Explain why.");
        prompts.Add("What subjects did you like the least? Explain why.");
        prompts.Add("Who were some of your friends in school? Explain what your friends were like and what they are doing today if you know that.");
        prompts.Add("If you went to college or a vocational school, what school did you attend? Describe what memories you have of those years and what subjects you studied.");
        prompts.Add("What do you see as your greatest strengths?");
        prompts.Add("What were some of the challenges you have had to deal with in your life?");
        prompts.Add("What medical issues have you had to deal with throughout your life?");
        prompts.Add("Was religion an important for you and your family? If so, explain what religion your family practiced and what it meant to you. Explain if it is or is not an important part of your life today.");
        prompts.Add("What foods do you like and dislike? Describe any food allergies you or other family members had.");
        prompts.Add("Were there two or three food dishes your mother or father made that were especially memorable?");
        prompts.Add("How did you meet your spouse?");
        prompts.Add("What was your courtship like? Describe your marriage day.");
        prompts.Add("Share some stories about your spouse.");
        prompts.Add("How many children do you have? List their names and share a few memories about each one.");
        prompts.Add("Describe some of the major community, national, and world events you lived through. How did these events change your life?");
        prompts.Add("What are some of your life philosophies or life views that you would share with others?");
        prompts.Add("What are some of the personal values that are very important to you? Share some examples of what have you done and what are you doing now to teach these values to your children, grandchildren and others.");
        prompts.Add("List at least five people who have had a memorable influence on your life. What did they do that had such an influence on you?");
        prompts.Add("What are 20 things about yourself that make you uniquely you?");
        prompts.Add("What are 50 things that you are grateful for?");
        prompts.Add("What is your philosophy on money?");
        prompts.Add("If you could spend a day with any famous person in the world, who would it be, and what would you do during your day with him or her?");
        prompts.Add("What scares you?");
        prompts.Add("What makes you stop and go “Wow!”?");
        prompts.Add("What are some of the things you enjoy doing in your leisure time?");
        prompts.Add("If you could go back in time and spend an hour visiting with yourself at age 15, what would you tell your younger self?");
        prompts.Add("What are some of your talents? Explain how you discovered them and what you have done to cultivate and improve them. Describe how your talents have they affected your life.");
        prompts.Add("What did you do for a career? Explain how you chose that career.");
        prompts.Add("What were some of the jobs you had throughout your life? Explain some of the memorable experiences you had with these jobs.");
        prompts.Add("What are 5 significant events or experiences in your life, and explain what effects they have had on you.");
        prompts.Add("What are some of the life lessons that you have learned and would like to pass on to your descendants?");
        prompts.Add("In how many places have you lived during your lifetime? Provide a brief description of each place you’ve lived, why you lived there, and why you moved.");
        prompts.Add("If someone gave you $10,000 and told you that you could NOT give it to any of your friends, family members or use it for yourself, what would you do with it?");
        prompts.Add("If you could go back in time and do things over again, what would you change?");
        prompts.Add("When all is said and done, what do you want to be remembered for? Explain what you are doing now to create a legacy worthy of remembering.");
        prompts.Add("If you were to leave 5 different bits of advice for your future posterity, what would they be?");
        prompts.Add("Have you traveled to any place outside of your home country? If so, explain the reasons for your trip(s) and what memorable things happened on some of those trips.");

    }
    public string getPrompt()
    {
        // foreach(string prompt in prompts)
        // {
        //     return prompt;
        // }

     for(int i = 0; i < prompts.Count; i++)
        {
            Console.WriteLine(prompts[i]);
            
        }
    }   
    
}    