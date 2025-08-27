# TODO - Add Popup Messages for View/Search Issues

## Steps to Complete:
1. [x] Fix MainMenuForm.Designer.cs - Connect proper event handlers
2. [x]极 MainMenuForm.cs - Add MessageBox.Show for both buttons
3. [x] Update MainMenuForm.cs - Hide main form when Report Issues is clicked
4. [x] Resize Attach Media button to appropriate size (120px)
5. [x] Implement attachment storage logic in ReportIssues.cs
6. [x] Restore MainMenuForm.Designer.cs to original state
7. [x] Add company title and copyright to MainMenuForm
8. [x] Add company title and copyright to ReportIssues form
9. [x] Add console output to show stored issues for verification
10. [ ] Test the application to verify all functionality works

## Details:
- View Issues button: Show message "View Issues feature will be added in later updates"
- Search Issue button: Show message "Search Issue feature will be added极 updates"
- Report Issues button: Hide main form when clicked, show again when ReportIssues form closes
- Attach Media button: Resized to 120px width
- Attachment storage: Files selected via OpenFileDialog are now properly stored with the issue
- Form data: Now uses actual user input instead of sample data
- Company branding: Added "Municipal Services Inc." title and copyright to all forms
- Verification: Console output shows stored issues when application starts
