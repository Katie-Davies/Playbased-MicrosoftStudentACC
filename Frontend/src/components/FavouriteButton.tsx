import { IconButton } from '@mui/material'
import { Favorite, FavoriteBorder } from '@mui/icons-material'
import { useState } from 'react'
import useAddFavourite from '../hooks/useAddFavourite'
import { useDeleteFavourite } from '../hooks/useDeleteFavourite'
import { Favourite } from '../models/models'

interface FavButtonProps {
  activityId: number
  userId: number
}

function FavouriteButton({ activityId, userId }: FavButtonProps) {
  const [liked, setLiked] = useState(false)
  const favourite = useAddFavourite()
  const deleteFavourite = useDeleteFavourite()

  async function handleLike(
    event: React.MouseEvent<HTMLButtonElement, MouseEvent>
  ) {
    event.stopPropagation()
    const favouriteData: Favourite = { userId, activityId }
    if (liked) {
      deleteFavourite.mutate(activityId)
    } else {
      favourite.mutate(favouriteData)
    }
    setLiked(!liked)
  }

  return (
    <IconButton onClick={handleLike} style={{ color: '#BF8C80' }}>
      {liked ? <Favorite style={{ color: '#BF8C80' }} /> : <FavoriteBorder />}
    </IconButton>
  )
}

export default FavouriteButton
