# GitHub Copilot Instructions for "Ignore Idle Guests" RimWorld Mod

## Mod Overview and Purpose
**Mod Name:** Ignore Idle Guests  
**Author:** Mlie  
**Package ID:** Mlie.IgnoreIdleGuests  

**Description:**  
"Ignore Idle Guests" is a mod for RimWorld that enhances the user experience by adjusting the idle colonist warning system. Specifically, it prevents the warning for idle colonists from triggering for guests or any pawns that cannot perform work. This modification is particularly beneficial for players managing colonies with numerous visiting guests or disabled/inactive pawns, as it reduces unnecessary and potentially distracting alerts.

## Key Features and Systems
- **Idle Alert Optimization:** The core feature of this mod is the intelligent filtering of idle alerts. By excluding guests and non-working pawns, players can focus on colonies' operational aspects without being distracted by alerts concerning individuals that don't require intervention.
- **Seamless Integration:** Designed to integrate smoothly within the existing game mechanics without requiring additional configuration. Users can install and enjoy the benefits without further setup.

## Coding Patterns and Conventions
- **C# Conventions:** The code follows standard C# coding conventions with clear and descriptive naming for classes and methods. Comments should be used to clarify the logic and purpose of significant code blocks.
- **File Organization:** The project contains two primary C# files, each corresponding to specific functionalities within the mod:
  - `IgnoreIdleGuests.cs`: Contains the main logic for ignoring idle guests.
  - `Alert_ColonistsIdle_IdleColonists.cs`: Implements postfix harmony patch to adjust the idle alert system.
  
## XML Integration
- Currently, there are no XML definitions or files involved in the mod. The mod is entirely implemented in C#, with Harmony patches being the primary vehicle for modifications. Future enhancements involving XML should ensure patch compatibility and maintain simplicity.

## Harmony Patching
- **Dependency:** The mod relies on the Harmony library (`brrainz.harmony`) for runtime code patches.
- **Patching Strategy:** 
  - The mod employs a postfix patch strategy on methods responsible for triggering idle alerts. This ensures that the base game functionality remains intact while adding the additional logic to filter specific idle notifications.
  - The `Alert_ColonistsIdle_IdleColonists` class patches the relevant method, allowing the game to determine if an alert should be suppressed based on the pawn's ability to perform work.

## Suggestions for Copilot
When using GitHub Copilot to extend or refactor the "Ignore Idle Guests" mod, consider the following suggestions:

- **Understand Contextual Methods:** Utilize Copilot to outline method stubs and quickly access documentation strings for base game methods, enhancing comprehension of where and how to apply patches.
- **Logic Complexity:** For complex logic within methods, let Copilot suggest potential algorithms or optimizations, but ensure these align with the intended mod functionality.
- **Code Efficiency:** Copilot can suggest methods to refactor or optimize the current C# codebase for better performance, especially regarding loop constructs and LINQ usage.
- **Error Handling:** Leverage Copilot’s suggestions for robust error handling and debugging implementations to ensure patches operate smoothly during various game states.
- **Collaboration Enhancements:** If multiple developers contribute, use Copilot to generate documentation comments and summaries to maintain codebase clarity and aid collaboration.

This instruction guide serves as a foundation for maintaining and extending the "Ignore Idle Guests" mod efficiently and effectively using GitHub Copilot as a development partner.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

