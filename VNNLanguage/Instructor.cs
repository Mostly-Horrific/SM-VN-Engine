﻿using System.Collections.Generic;
using VNNLanguage.Model;
using System;
using VNNLanguage.Exceptions;
using VNNMedia;

namespace VNNLanguage
{
    public class Instructor : IInstructor
    {
        private IContentManager contentManager;

        public Instructor(IContentManager contentManager)
        {
            this.contentManager = contentManager;
        }

        //TODO: FIX Issue #8 first
        public void AddCharacter(string friendlyName, string spriteName, Animation animation)
        {
            var image = contentManager.GetCharacterImage(friendlyName, spriteName.Replace("*", string.Empty));
            throw new NotImplementedException();
        }

        public void ChangeBackground(byte[] image)
        {
            throw new NotImplementedException();
        }

        public void ChangeCharacterDisplayName(string friendlyName, string displayName)
        {
            CharacterState.Instance.ChangeCharacterName(friendlyName, displayName);
        }

        public void ChangeCharacterSprite(string friendlyName, string spriteName)
        {
            var image = contentManager.GetCharacterImage(friendlyName, spriteName.Replace("*", string.Empty));
            if (CharacterState.Instance.ChangeSprite(friendlyName, image))
            {
                throw new NotImplementedException();
            }
        }

        public bool CheckCharacterExists(string friendlyName)
        {
            return CharacterState.Instance.RemoveCharacter(friendlyName);
        }

        public void CreateFork(IEnumerable<(string text, string forkHandlerName)> choices)
        {
            throw new NotImplementedException();
        }

        public void EndGame()
        {
            throw new NotImplementedException();
        }

        public void HideCharacter(string friendlyName, Animation animation)
        {
            if (!CharacterState.Instance.HideCharacter(friendlyName))
            {
                throw new NotImplementedException();
            }
        }

        public void JumpLine(int number)
        {
            throw new NotImplementedException();
        }

        public void MoveCharacter(string friendlyName, Direction direction, int pixels)
        {
            throw new NotImplementedException();
        }

        public void PlaceCharacter(string friendlyName, int x, int y, int scaleHeight = 0, int scaleWidth = 0)
        {
            if(CharacterState.Instance.PlaceCharacter(friendlyName, x, y, scaleHeight, scaleWidth))
            {
                throw new NotImplementedException();
            }
            throw new ArgumentNullException($"Failed to place {friendlyName}");
        }

        public void PlaySound(byte[] sound)
        {
            throw new NotImplementedException();
        }

        public void RemoveCharacter(string friendlyName, Animation animation)
        {
            if(!CharacterState.Instance.RemoveCharacter(friendlyName))
            {
                throw new ArgumentNullException($"Failed to remove {friendlyName}");
            }
        }

        public void ShowCharacter(string friendlyName, Animation animation)
        {
            if (!CharacterState.Instance.ShowCharacter(friendlyName))
            {
                throw new NotImplementedException();
            }
        }

        public void WriteLine(string text, string character)
        {
            throw new NotImplementedException();
        }
    }

}